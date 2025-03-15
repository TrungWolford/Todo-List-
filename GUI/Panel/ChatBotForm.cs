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

            txtOutput.Invoke((MethodInvoker)delegate {
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
            SendPredefinedMessage("Làm thế nào để học AI giỏi hơn");
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            SendPredefinedMessage("Lộ trình học để trở thành một fullstack java developer trong vòng 12 tháng?");
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            SendPredefinedMessage("Làm sao để giỏi thuật toán?");
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
