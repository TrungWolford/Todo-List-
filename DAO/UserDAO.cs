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
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }

        public void Update(UserDTO user) { }
        public void Delete(UserDTO user) { }
    }
}
