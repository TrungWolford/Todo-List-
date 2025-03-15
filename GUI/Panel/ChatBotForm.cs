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

            string dbAnswer = GetAnswerFromDatabase(userMessage);
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

            Console.WriteLine("API Key: " + apiKey);
        }

        private static async Task<string> GetDeepSeekResponse(string userMessage)
        {
            using (HttpClient client = new HttpClient())
            {
                // Thêm API Key vào Header
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

                // Tạo dữ liệu JSON gửi lên API
                var requestBody = new
                {
                    model = "deepseek/deepseek-r1:free", // Sử dụng model miễn phí
                    messages = new[]
                    {
        new { role = "user", content = userMessage }
    }
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);

                // Định dạng JSON request với Content-Type
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                // Gửi request đến API
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                string responseString = await response.Content.ReadAsStringAsync();

                // Xử lý JSON phản hồi từ API
                dynamic responseData = JsonConvert.DeserializeObject(responseString);
                if (responseData?.choices != null && responseData.choices.Count > 0)
                {
                    return responseData.choices[0].message.content.ToString();
                }
                Console.WriteLine("JSON Request: " + jsonRequest);

                return "❌ Không có phản hồi từ DeepSeek.";
            }
        }

        private static string LoadApiKey()
        {
            string filePath = "appsettings.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                JObject config = JObject.Parse(json);
                return config["OpenAI"]?["ApiKey"]?.ToString() ?? string.Empty;
            }
            return string.Empty;
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


        private static string GetAnswerFromDatabase(string userQuestion)
        {
            string connectionString = GetConnectionString(); // Lấy chuỗi kết nối từ App.config
            string query = "SELECT Answer FROM ChatQA WHERE Question = @question";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@question", userQuestion);
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
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
    }
}
