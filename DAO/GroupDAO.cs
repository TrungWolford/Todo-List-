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
    public class GroupDAO : InterfaceDAO<GroupDTO>
    {
        public void Insert(GroupDTO group)
        {
            string query = "INSERT INTO Group (Title, CreatedBy, CreatedDate) VALUES (@title, @createdBy, @createdDate)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", SqlDbType.NVarChar) { Value = group.Title },
                new SqlParameter("@description", SqlDbType.Int) { Value = group.CreatedBy },
                new SqlParameter("@dueDate", SqlDbType.DateTime) { Value = group.CreatedDate }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Update(GroupDTO group) { }
        public void Delete(GroupDTO group) { }
    }
}
