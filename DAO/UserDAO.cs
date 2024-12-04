using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DAO
{
    public class UserDAO : InterfaceDAO<UserDTO>
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }
        public UserDAO() { }
        public int Insert(UserDTO user)
        {

            string query = "INSERT INTO [User] (Username, Password_hash, Email, CreatedDate) VALUES (@username, @password_hash, @email, @createdDate); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", SqlDbType.NVarChar) { Value = user.UserName },
                new SqlParameter("@password_hash", SqlDbType.NVarChar) { Value = user.Password },
                new SqlParameter("@email", SqlDbType.NVarChar) { Value = user.Email },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = user.CreatedDate }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                user.UserID = newId;
                return newId;
            }
            return -1;
        }

        public int Update(UserDTO user) 
        {
            string query = "UPDATE [User] SET Username = @username, Password_hash = @password_hash, Email = @email, CreatedDate = @createdDate WHERE UserID = @userID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", SqlDbType.NVarChar) { Value = user.UserName },
                new SqlParameter("@password_hash", SqlDbType.NVarChar) { Value = user.Password },
                new SqlParameter("@email", SqlDbType.NVarChar) { Value = user.Email },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = user.CreatedDate },
                new SqlParameter("@userID", SqlDbType.Int) { Value = user.UserID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
        public int Delete(UserDTO user) 
        {
            string query = "DELETE FROM [User] WHERE UserID = @userID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = user.UserID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }

        public bool CheckLogin(string username, string password_hash)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Username = @username AND Password_hash = @password_hash";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@username", SqlDbType.NVarChar) { Value = username },
                new SqlParameter ("@password_hash", SqlDbType.NVarChar) { Value = password_hash }
            };
            // Sử dụng ExecuteScalar để kiểm tra số lượng bản ghi
            int result = Convert.ToInt32(DatabaseAccess.ExecuteScalar(query, parameters));
            return result > 0; // Nếu có ít nhất 1 bản ghi thì thông tin đăng nhập hợp lệ
        }

        public int SelectByID(string username)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Username = @username";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@username", SqlDbType.NVarChar) {Value = username }
            };
            int result = Convert.ToInt32(DatabaseAccess.ExecuteScalar(query, parameters));
            return result;
        }

        public List<UserDTO> selectByUsername(string username)
        {
            List<UserDTO> listUser = new List<UserDTO>();
            string query = "SELECT * FROM [User] WHERE Username=@username";

            List<SqlParameter> parameters = new List<SqlParameter>() 
            { 
                new SqlParameter("@username", username)
            };

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    UserDTO userDTO = new UserDTO
                    {
                        UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                        UserName = reader.GetString(reader.GetOrdinal("Username")),
                        Password = reader.GetString(reader.GetOrdinal("Password_hash")),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                    };
                    listUser.Add(userDTO);
                }
            }
            return listUser;
        }

        public List<UserDTO> GetAll()
        {
            List<UserDTO> users = new List<UserDTO>();
            string query = "SELECT * FROM [User]";
            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, null)) // 'using' với reader nhưng không đóng kết nối
            {
                while (reader.Read())
                {
                    UserDTO user = new UserDTO
                    {
                        UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                        UserName = reader.GetString(reader.GetOrdinal("Username")),
                        Password = reader.GetString(reader.GetOrdinal("Password_hash")),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                    };
                    users.Add(user);
                }
            }

            return users;
        }

        public UserDTO selectedByID(int userID)
        {
            try
            {
                UserDTO user = null;
                string query = "SELECT * FROM [User] WHERE UserID = @userID";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@userID", SqlDbType.Int) { Value = userID }
                };

                using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        user = new UserDTO
                        {
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            UserName = reader.GetString(reader.GetOrdinal("Username")),
                            Password = reader.GetString(reader.GetOrdinal("Password_hash")),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                            CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                        };
                    }
                }

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public UserDTO selectedByName(string name)
        {
            try
            {
                UserDTO user = null; 
                string query = "SELECT * FROM [User] WHERE Username = @username"; 

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@username", SqlDbType.NVarChar) { Value = name }
                };

                using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
                {
                    if (reader.Read()) 
                    {
                        user = new UserDTO
                        {
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            UserName = reader.GetString(reader.GetOrdinal("Username")),
                            Password = reader.GetString(reader.GetOrdinal("Password_hash")),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                            CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                        };
                    }
                }

                return user; 
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
                return null; 
            }
        }
    }
}
