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
    public class GroupMemberShipDAO : InterfaceDAO<GroupMemberShipDTO>
    {
        public void Insert(GroupMemberShipDTO groupMemberShip)
        {
            string query = "INSERT INTO GroupMemberShip (GroupID, UserID, JoinedDate) VALUES (@groupID, @userID, @joinedDate)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@groupID", SqlDbType.Int) { Value = groupMemberShip.GroupID },
                new SqlParameter("@userID", SqlDbType.Int) { Value = groupMemberShip.UserID },
                new SqlParameter("@joinedDate", SqlDbType.DateTime) { Value = groupMemberShip.JoinedDate }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Update(GroupMemberShipDTO groupMemberShip) { }
        public void Delete(GroupMemberShipDTO groupMemberShip) { }
    }
}
