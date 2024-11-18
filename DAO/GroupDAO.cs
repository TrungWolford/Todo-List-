using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net.Mail;

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
        public void Insert(GroupDTO group)
        {
            string query = "INSERT INTO Group (Title, CreatedBy, CreatedDate) VALUES (@title, @createdBy, @createdDate)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", SqlDbType.NVarChar) { Value = group.Title },
                new SqlParameter("@description", SqlDbType.Int) { Value = group.CreatedBy },
                new SqlParameter("@dueDate", SqlDbType.DateTime) { Value = group.CreatedDate }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            int newId = Convert.ToInt32(result);

            group.GroupID = newId;
        }
        public void Update(GroupDTO group) 
        {
            string query = "UPDATE Group SET Title = @title, CreatedBy = @createdBy, CreatedDate = @createdDate WHERE GroupID = @groupID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", SqlDbType.NVarChar) { Value = group.Title },
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = group.CreatedBy },
                new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = group.CreatedDate },
                new SqlParameter("@groupID", SqlDbType.Int) { Value = group.GroupID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Delete(GroupDTO group) 
        {
            string query = "DELETE FROM Group WHERE GroupID = @groupID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@groupID", SqlDbType.Int) { Value = group.GroupID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
