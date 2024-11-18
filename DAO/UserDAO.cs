using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class UserDAO : InterfaceDAO<UserDTO>
    {
        public void Insert(UserDTO user)
        {
            string query = "INSERT INTO User (Username, Password_hash, Email, CreatedDate) VALUES (@username, @password_hash, @email, @createdDate)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", SqlDbType.NVarChar) { Value = user.UserName },
                new SqlParameter("@password_hash", SqlDbType.NVarChar) { Value = user.Password },
                new SqlParameter("@email", SqlDbType.NVarChar) { Value = user.Email },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = user.CreatedDate }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            int newId = Convert.ToInt32(result);

            user.UserID = newId;
        }

        public void Update(UserDTO user) 
        {
            string query = "UPDATE User SET Username = @username, Password_hash = @password_hash, Email = @email, CreatedDate = @createdDate WHERE UserID = @userID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", SqlDbType.NVarChar) { Value = user.UserName },
                new SqlParameter("@password_hash", SqlDbType.NVarChar) { Value = user.Password },
                new SqlParameter("@email", SqlDbType.NVarChar) { Value = user.Email },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = user.CreatedDate },
                new SqlParameter("@userID", SqlDbType.Int) { Value = user.UserID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Delete(UserDTO user) 
        {
            string query = "DELETE FROM User WHERE UserID = @userID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = user.UserID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
