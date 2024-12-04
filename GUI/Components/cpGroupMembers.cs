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

namespace GUI.Components
{
    public partial class cpGroupMembers : UserControl
    {
        private GroupDTO groupDTO;
        public cpGroupMembers()
        {
            InitializeComponent();
        }
        public cpGroupMembers(string userName, string role, GroupDTO groupDTO)
        {
            InitializeComponent();
            this.groupDTO = groupDTO;
            lblUsername.Text = userName;    
            lblRoleUser.Text = role;
        }
    }
}
