using DTO;
using BUS;
using GUI.Panel;
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
    public partial class cpToolBarGroup : UserControl
    {
        private GroupDTO groupDTO;
        private UserDTO userDTO;
        private GroupMemberShipBUS groupMemberShipBUS;

        public cpToolBarGroup()
        {
            InitializeComponent();
            UpdateCurrentTime();
        }
        public cpToolBarGroup(GroupDTO groupDTO, UserDTO userDTO,Form form)
        {
            this.groupDTO = groupDTO;
            this.userDTO = userDTO;
            groupMemberShipBUS = new GroupMemberShipBUS();
            InitializeComponent();
            UpdateCurrentTime();
            UpdateTitle(form);
            CountNumber();
        }

        private void UpdateTitle(Form formChild)
        {
            if (formChild is Group)
            {
                lblTop_titleGroup.Text = groupDTO.Title;
            }
            else
            {
                lblTop_titleGroup.Text = "Unname Group";
            }
        }

        private void UpdateCurrentTime()
        {
            lblTop_currentTimeGroup.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        private void lblTop_memberGroup_Click(object sender, EventArgs e)
        {
            Member member = new Member(groupDTO, userDTO);
            member.ShowDialog();

        }

        public void CountNumber()
        {
            int count = groupMemberShipBUS.countAllMemberByGroupID(groupDTO.GroupID);
            if (count > 0)
            {
                lblTop_memberGroup.Text = count.ToString();
            }
            else
            {
                lblTop_memberGroup.Text = "";
            }
        }

        private void lblTop_memberGroup_MouseEnter(object sender, EventArgs e)
        {
            lblTop_memberGroup.BackColor = Color.FromArgb(228, 237, 255);
        }

        private void lblTop_memberGroup_MouseLeave(object sender, EventArgs e)
        {
            lblTop_memberGroup.BackColor = Color.FromArgb(246, 246, 246);
        }
    }
}
