using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI.Panel
{
    public partial class Group : Form
    {
        private UserDTO user;
        private List<GroupDTO> groups;
        public GroupBUS groupBUS;
        public Group(UserDTO user)
        {
            this.user = user;
            InitializeComponent();
            groupBUS = new GroupBUS();
            groups = groupBUS.getAllByUserID(user.UserID);
        }
    }
}
