using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GroupBUS
    {
        public List<GroupDTO> groups;
        private static readonly GroupDAO groupDAO = GroupDAO.Instance;

        public GroupBUS()
        {
            groups = groupDAO.GetAll();
        }

        public List<GroupDTO> getAllByUserID(int id)
        {
            return groupDAO.selectedByID(id);
        }

        public bool checkGroupTitleExistence(string groupName, int userID)
        {
            try
            {
                bool check = groupDAO.FindGroupTitleExistence(groupName, userID);
                if (check)
                {
                    return check;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while checking duplicate title: " + ex.Message);
                return false;
            }
        }

        public bool insert(GroupDTO groupDTO)
        {

            try
            {

                bool check = groupDAO.Insert(groupDTO) != 0;

                if (check)
                {
                    this.groups.Add(groupDTO);
                }

                return check;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting group: " + ex.Message);
                return false;
            }
        }

        public bool delete(GroupDTO groupDTO)
        {
            try
            {
                bool check = groupDAO.Delete(groupDTO) != -1;
                if (check)
                {
                    groups.Remove(groupDTO);
                    return check;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting group: " + ex.Message);
                return false;
            }
        }
    }
}
