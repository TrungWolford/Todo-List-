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
                Console.WriteLine("Error while inserting task: " + ex.Message);
                return false;
            }
        }


    }
}
