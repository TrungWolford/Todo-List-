using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GUI.Panel
{
    internal class TfIdfVectorizer
    {
        private readonly MLContext mlContext = new MLContext();

        public string FindMostSimilarQuestion(string userQuestion, Dictionary<string, string> dbQuestions)
        {
            if (dbQuestions == null || dbQuestions.Count == 0)
                return null;

            userQuestion = NormalizeText(userQuestion);

            // Nếu câu hỏi trùng khớp 100%, trả về ngay câu trả lời
            if (dbQuestions.ContainsKey(userQuestion))
                return dbQuestions[userQuestion];

            var questionList = dbQuestions.Keys.Select(q => NormalizeText(q)).ToList();
            questionList.Insert(0, userQuestion);

            var data = questionList.Select(q => new InputText { Text = q }).ToList();
            IDataView dataView = mlContext.Data.LoadFromEnumerable(data);

            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", "Text");
            var model = pipeline.Fit(dataView);
            IDataView transformedData = model.Transform(dataView);

            var featureColumn = mlContext.Data.CreateEnumerable<FeatureData>(transformedData, reuseRowObject: false).ToList();

            var userVector = featureColumn[0].Features;

            int bestMatchIndex = -1;
            float bestSimilarity = -1;
            for (int i = 1; i < featureColumn.Count; i++)
            {
                float similarity = CosineSimilarity(userVector, featureColumn[i].Features);
                if (similarity > bestSimilarity)
                {
                    bestSimilarity = similarity;
                    bestMatchIndex = i - 1;
                }
            }

            const float SIMILARITY_THRESHOLD = 0.7f; // Ngưỡng xác định câu hỏi có đủ tương đồng hay không

            if (bestMatchIndex >= 0 && bestSimilarity >= SIMILARITY_THRESHOLD)
            {
                return dbQuestions[dbQuestions.Keys.ElementAt(bestMatchIndex)];
            }
            return null; // Trả về null để báo hiệu rằng không tìm thấy câu hỏi phù hợp
        }

        private float CosineSimilarity(float[] vectorA, float[] vectorB)
        {
            if (vectorA.Length != vectorB.Length)
                return 0;

            float dotProduct = 0, normA = 0, normB = 0;
            for (int i = 0; i < vectorA.Length; i++)
            {
                dotProduct += vectorA[i] * vectorB[i];
                normA += vectorA[i] * vectorA[i];
                normB += vectorB[i] * vectorB[i];
            }

            return (float)(dotProduct / (Math.Sqrt(normA) * Math.Sqrt(normB) + 1e-8)); // Tránh chia cho 0
        }

        private string NormalizeText(string text)
        {
            text = text.ToLower();
            text = Regex.Replace(text, @"\s+", " "); // Chuẩn hóa khoảng trắng
            text = Regex.Replace(text, @"[^\w\s]", ""); // Xóa ký tự đặc biệt
            return text.Trim();
        }

        public class InputText { public string Text { get; set; } }
        private class FeatureData { public float[] Features { get; set; } }
    }
}
