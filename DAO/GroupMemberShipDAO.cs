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
    public class GroupMemberShipDAO : InterfaceDAO<GroupMemberShipDTO>
    {
        private static GroupMemberShipDAO instance;
        public static GroupMemberShipDAO Instance
        {
            get { if (instance == null) instance = new GroupMemberShipDAO(); return instance; }
            private set { instance = value; }
        }
        private GroupMemberShipDAO() { }
        public int Insert(GroupMemberShipDTO groupMemberShip)
        {
            string query = "INSERT INTO GroupMemberShip (GroupID, UserID, JoinedDate) VALUES (@groupID, @userID, @joinedDate)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@groupID", SqlDbType.Int) { Value = groupMemberShip.GroupID },
                new SqlParameter("@userID", SqlDbType.Int) { Value = groupMemberShip.UserID },
                new SqlParameter("@joinedDate", SqlDbType.DateTime) { Value = groupMemberShip.JoinedDate }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                groupMemberShip.MemberShipID = newId;
                return newId;
            }
            return -1;
        }
        public int Update(GroupMemberShipDTO groupMemberShip) 
        {
            string query = "UPDATE GroupMemberShip SET GroupID = @groupID, UserID = @userID, JoinedDate = @joinedDate WHERE MemberShipID = @memberShipID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@groupID", SqlDbType.Int) { Value = groupMemberShip.GroupID },
                new SqlParameter("@userID", SqlDbType.Int) { Value = groupMemberShip.UserID },
                new SqlParameter("@joinedDate", SqlDbType.DateTime) { Value = groupMemberShip.JoinedDate },
                new SqlParameter("@memberShipID", SqlDbType.Int) { Value = groupMemberShip.MemberShipID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
        public int Delete(GroupMemberShipDTO groupMemberShip) 
        {
            string query = "DELETE FROM GroupMemberShip WHERE MemberShipID = @memberShipID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@memberShipID", SqlDbType.Int) { Value = groupMemberShip.MemberShipID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }

        public List<GroupMemberShipDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
