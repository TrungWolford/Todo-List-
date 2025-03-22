using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using System.Data.SqlClient;
using Accord.MachineLearning.Text;
using Accord.Statistics.Filters;
using Microsoft.ML;
using Microsoft.ML.Transforms.Text;
using MathNet.Numerics.LinearAlgebra;

namespace GUI.Panel
{
    public partial class ChatBotForm : Form
    {
        private static readonly string apiKey = "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";
        private static readonly string apiUrl = "https://openrouter.ai/api/v1/chat/completions";

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        }
        public ChatBotForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtOutput.Multiline = true;
            txtOutput.WordWrap = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(userMessage)) return;

            txtOutput.AppendText($"Bạn: {userMessage}\r\n");
            txtInput.Clear();

            string dbAnswer = GetBestAnswerFromDatabase(userMessage);
            if (dbAnswer != null)
            {
                txtOutput.AppendText($"Chatbot: {dbAnswer}\r\n\r\n");
                return;
            }

            string response = await GetDeepSeekResponse(userMessage);

            txtOutput.Invoke((MethodInvoker)delegate
            {
                txtOutput.AppendText($"Chatbot: {response}\r\n\r\n");
            });

            SaveAnswerToDatabase(userMessage, response);
        }

        private static async Task<string> GetDeepSeekResponse(string userMessage)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

                var requestBody = new
                {
                    model = "deepseek/deepseek-r1:free",
                    messages = new[] { new { role = "user", content = userMessage } }
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();

                dynamic responseData = JsonConvert.DeserializeObject(responseString);
                if (responseData?.choices != null && responseData.choices.Count > 0)
                {
                    return responseData.choices[0].message.content.ToString();
                }

                return "❌ Không có phản hồi từ DeepSeek.";
            }
        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            SendPredefinedMessage("Làm sao để duy trì thói quen sử dụng To-Do List hàng ngày?");
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            SendPredefinedMessage("Có phương pháp nào giúp hoàn thành To-Do List mà không bị stress?");
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            SendPredefinedMessage("Làm sao để đánh giá hiệu quả của To-Do List?");
        }

        private void SendPredefinedMessage(string message)
        {
            txtInput.AppendText($"{message}\r\n");
            //txtInput.Text = message;
            btnSend.PerformClick();
        }

        //private static string GetBestAnswerFromDatabase(string userQuestion)
        //{
        //    Dictionary<string, string> qaPairs = LoadQuestionsFromDB();
        //    if (qaPairs.Count == 0) return null;

        //    var documents = qaPairs.Keys.ToList();
        //    var vectorizer = new TfIdfVectorizer();
        //    vectorizer.Learn(documents);
        //    var matrix = vectorizer.Transform(documents);

        //    var userVector = vectorizer.Transform(new List<string> { userQuestion })[0];
        //    double maxSimilarity = 0;
        //    string bestMatch = null;

        //    for (int i = 0; i < documents.Count; i++)
        //    {
        //        double similarity = CosineSimilarity(userVector, matrix[i]);
        //        if (similarity > maxSimilarity)
        //        {
        //            maxSimilarity = similarity;
        //            bestMatch = documents[i];
        //        }
        //    }

        //    return maxSimilarity > 0.5 ? qaPairs[bestMatch] : null;
        //}

        private static string GetBestAnswerFromDatabase(string userQuestion)
        {
            Dictionary<string, string> qaPairs = LoadQuestionsFromDB();
            if (qaPairs.Count == 0) return null;

            var vectorizer = new TfIdfVectorizer();
            string bestAnswer = vectorizer.FindMostSimilarQuestion(userQuestion, qaPairs);
            return string.IsNullOrEmpty(bestAnswer) ? null : bestAnswer;
        }

        private static double CosineSimilarity(double[] vec1, double[] vec2)
        {
            double dotProduct = 0, normA = 0, normB = 0;
            for (int i = 0; i < vec1.Length; i++)
            {
                dotProduct += vec1[i] * vec2[i];
                normA += Math.Pow(vec1[i], 2);
                normB += Math.Pow(vec2[i], 2);
            }
            return dotProduct / (Math.Sqrt(normA) * Math.Sqrt(normB));
        }

        private static void SaveAnswerToDatabase(string question, string answer)
        {
            string connectionString = GetConnectionString();
            string query = "INSERT INTO ChatQA (Question, Answer) VALUES (@question, @answer)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@question", question);
                    command.Parameters.AddWithValue("@answer", answer);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static Dictionary<string, string> LoadQuestionsFromDB()
        {
            Dictionary<string, string> questionsWithAnswers = new Dictionary<string, string>();
            string connectionString = GetConnectionString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Question, Answer FROM ChatQA";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string question = reader.GetString(0);
                        string answer = reader.GetString(1);
                        questionsWithAnswers[question] = answer;
                    }
                }
            }
            return questionsWithAnswers;
        }
    }
}
