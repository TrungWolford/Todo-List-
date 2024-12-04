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
using System.Transactions;
using System.Data.Common;

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
            string query = "INSERT INTO GroupMemberShip (GroupID, UserID, JoinedDate) VALUES (@groupID, @userID, @joinedDate); SELECT SCOPE_IDENTITY();";
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
            return 0;
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
            List<GroupMemberShipDTO> groupMemberShips = new List<GroupMemberShipDTO>();
            string query = "SELECT * FROM [GroupMemberShip]";
            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, null)) 
            {
                while (reader.Read())
                {
                    GroupMemberShipDTO groupMemberShip = new GroupMemberShipDTO
                    {
                        MemberShipID = reader.GetInt32(reader.GetOrdinal("MemberShipID")),
                        GroupID = reader.GetInt32(reader.GetOrdinal("GroupID")),
                        UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                        JoinedDate = reader.GetDateTime(reader.GetOrdinal("JoinedDate"))
                    };
                    groupMemberShips.Add(groupMemberShip);
                }
            }
            return groupMemberShips;
        }

        public GroupMemberShipDTO selectedByID(int t)
        {
            throw new NotImplementedException();
        }

        public List<GroupMemberShipDTO> selectedAllMemberByGroupID(int groupID)
        {
            List<GroupMemberShipDTO> groupMemberShips = new List<GroupMemberShipDTO>();
            string query = "SELECT * FROM [GroupMemberShip] WHERE GroupID = @groupID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@groupID", groupID)
            };
            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    GroupMemberShipDTO groupMemberShip = new GroupMemberShipDTO
                    {
                        MemberShipID = reader.GetInt32(reader.GetOrdinal("MemberShipID")),
                        GroupID = reader.GetInt32(reader.GetOrdinal("GroupID")),
                        UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                        JoinedDate = reader.GetDateTime(reader.GetOrdinal("JoinedDate"))
                    };
                    groupMemberShips.Add(groupMemberShip);
                }
            }
            return groupMemberShips;
        }

        public bool checkUserExist(int userID, int groupID)
        {
            string query = "SELECT COUNT(*) FROM [GroupMemberShip] WHERE UserID = @userID AND GroupID = @groupID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@userID", SqlDbType.Int) {Value = userID },
                new SqlParameter ("@groupID", SqlDbType.Int) {Value = groupID }
            };
            try
            {
                object result = DatabaseAccess.ExecuteScalar(query, parameters);

                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CheckUserExist: " + ex.Message);
                return false; 
            }
        }

        public int countMemberByGroupID(int groupID)
        {
            string query = "SELECT COUNT(*) FROM [GroupMemberShip] WHERE GroupID = @groupID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter ("@groupID", SqlDbType.Int) {Value = groupID }
            };
            int result = Convert.ToInt32(DatabaseAccess.ExecuteScalar(query, parameters));
            return result;
        }

        public int DeleteUserByID(int userID, int groupID)
        {

            string query = "DELETE FROM GroupMemberShip WHERE GroupID = @groupID AND UserID = @userID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@groupID", SqlDbType.Int) { Value = groupID },
                new SqlParameter("@userID", SqlDbType.Int) { Value = userID }
            };

            try
            {
                int rowsAffected1 = DatabaseAccess.ExecuteNonQuery(query, parameters);

                return rowsAffected1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in RemoveMemberFromGroup: " + ex.Message);
                return -1; 
            }
        }
    }
}
