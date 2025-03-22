using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChatbotDAO
    {
        private static ChatbotDAO instance;
        public static ChatbotDAO Instance
        {
            get { if (instance == null) instance = new ChatbotDAO(); return instance; }
            private set { instance = value; }
        }
        public ChatbotDAO() { }

        public int Insert(ChatbotDTO chatbot)
        {
            // sua TaskID
            string query = "INSERT INTO Task (Question, Answer) VALUES (@quetion, @answer); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@quetion", SqlDbType.NVarChar) { Value = chatbot.Question },
                new SqlParameter("@answer", SqlDbType.NVarChar) { Value = chatbot.Answer ?? (object)DBNull.Value}
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                chatbot.IDbot = newId;
                return newId;
            }
            return 0;
        }

        public List<ChatbotDTO> GetAll()
        {
            List<ChatbotDTO> listQuestion = new List<ChatbotDTO>();
            string query = "SELECT * FROM ChatQA";

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, null)) // 'using' với reader nhưng không đóng kết nối
            {
                while (reader.Read())
                {
                    ChatbotDTO chatbot = new ChatbotDTO
                    {
                        IDbot = reader.GetInt32(reader.GetOrdinal("Id")),
                        Question = reader.GetString(reader.GetOrdinal("Question")),
                        Answer = reader.GetString(reader.GetOrdinal("Answer"))
                    };
                    listQuestion.Add(chatbot);
                }
            }

            return listQuestion;
        }
    }
}
