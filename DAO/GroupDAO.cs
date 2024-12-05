using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAO
{
    public class GroupDAO : InterfaceDAO<GroupDTO>
    {
        private static GroupDAO instance;
        public static GroupDAO Instance
        {
            get { if (instance == null) instance = new GroupDAO(); return instance; }
            private set { instance = value; }
        }
        private GroupDAO() { }
        public int Insert(GroupDTO group)
        {
            string query = "INSERT INTO [Group] (Title, CreatedBy, CreatedDate) VALUES (@title, @createdBy, @createdDate); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", SqlDbType.NVarChar) { Value = group.Title },
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = group.CreatedBy },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = group.CreatedDate }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                group.GroupID = newId;
                return newId;
            }
            return 0;
        }
        public int Update(GroupDTO group) 
        {
            string query = "UPDATE [Group] SET Title = @title, CreatedBy = @createdBy, CreatedDate = @createdDate WHERE GroupID = @groupID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", SqlDbType.NVarChar) { Value = group.Title },
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = group.CreatedBy },
                new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = group.CreatedDate },
                new SqlParameter("@groupID", SqlDbType.Int) { Value = group.GroupID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
        public int Delete(GroupDTO group) 
        {
            //Sử dụng BEGIN TRANSACTION để đảm bảo tính toàn vẹn dữ liệu.
            //Nếu có lỗi trong một trong các lệnh xóa, giao dịch có thể ROLLBACK để tránh xóa dữ liệu không đầy đủ.
            string query = @"
                    BEGIN TRANSACTION;
                    DELETE FROM Task WHERE GroupID = @groupID;
                    DELETE FROM GroupMembership WHERE GroupID = @groupID;
                    DELETE FROM [Group] WHERE GroupID = @groupID;
                    COMMIT TRANSACTION;";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@groupID", SqlDbType.Int) { Value = group.GroupID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1;
        }


        public List<GroupDTO> GetAll()
        {
            List<GroupDTO> groups = new List<GroupDTO>();
            string query = "SELECT * FROM [Group]";

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, null)) // 'using' với reader nhưng không đóng kết nối
            {
                while (reader.Read())
                {
                    GroupDTO group = new GroupDTO
                    {
                        GroupID = reader.GetInt32(reader.GetOrdinal("GroupID")),
                        Title = reader.GetString(reader.GetOrdinal("Title")),
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))                     
                    };
                    groups.Add(group);
                }
            }

            return groups;
        }

        public List<GroupDTO> selectedByID(int userID)
        {
            List<GroupDTO> groupsByID = new List<GroupDTO>();
            string query = @"
                    SELECT *
                    FROM [Group] g
                    INNER JOIN GroupMembership gms ON g.GroupID = gms.GroupID
                    WHERE gms.UserID = @UserID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    GroupDTO group = new GroupDTO
                    {
                        GroupID = reader.GetInt32(reader.GetOrdinal("GroupID")),
                        Title = reader.GetString(reader.GetOrdinal("Title")),
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                    };
                    groupsByID.Add(group);
                }
            }

            return groupsByID;
        }

        

        public bool FindGroupTitleExistence(string nameGroup, int userID)
        {
            string query = "SELECT COUNT(*) FROM [Group] WHERE Title = @title AND CreatedBy = @userID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", nameGroup),
                new SqlParameter("@userID", userID)
            };
            try
            {
                int count = (int)DatabaseAccess.ExecuteScalar(query, parameters);
                return count > 0;
            }
            catch(Exception ex) {
                Console.WriteLine("Error while checking duplicate title: " + ex.Message);
                return false;
            }
        }

        GroupDTO InterfaceDAO<GroupDTO>.selectedByID(int t)
        {
            throw new NotImplementedException();
        }

    }
}
