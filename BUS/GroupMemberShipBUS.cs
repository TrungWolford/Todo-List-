using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GroupMemberShipBUS
    {
        List<GroupMemberShipDTO> groupMemberShipDTOs;
        private static readonly GroupMemberShipDAO groupMemberShipDAO = GroupMemberShipDAO.Instance;

        public GroupMemberShipBUS()
        {
            groupMemberShipDTOs = groupMemberShipDAO.GetAll();
        }

        public List<GroupMemberShipDTO> getAllMemberByGroupID(int groupID)
        {
            return groupMemberShipDAO.selectedAllMemberByGroupID(groupID);
        }

        public bool userExistion(int userID, int groupID)
        {
            try
            {
                bool check = groupMemberShipDAO.checkUserExist(userID, groupID);
                if (check)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int countAllMemberByGroupID(int groupID)
        {
            return groupMemberShipDAO.countMemberByGroupID(groupID);
        }

        public bool insert(GroupMemberShipDTO groupMemberShip)
        {
            try
            {
                bool check = groupMemberShipDAO.Insert(groupMemberShip) != -1;
                if (check)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool removeUserByID(int userID, int groupID)
        {
            try
            {
                bool check = groupMemberShipDAO.DeleteUserByID(userID, groupID) != -1;
                if (check)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
