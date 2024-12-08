using BUS;
using DTO;
using GUI.Panel;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Components
{
    public partial class MenuTaskBar : Form
    {
        private Main main;
        private Label selectedLabel;
        private UserDTO user;
        private GroupBUS groupBUS;
        private GroupMemberShipBUS membershipBUS;
        private List<GroupDTO> groups;
        private List<NewGroup> groupControls; 
        private List<Label> mainLabels;

        public MenuTaskBar(Main main)
        {
            this.main = main;
            InitializeComponent();
            SelectLabel(lbl_itemMyday);
        }
        public MenuTaskBar(Main main, UserDTO user)
        {
            this.main = main;
            this.user = user;
            InitializeComponent();

            groupBUS = new GroupBUS();
            membershipBUS = new GroupMemberShipBUS();
            groups = groupBUS.getAllByUserID(user.UserID);
            pnlitem_GroupName.Visible = false;  
            groupControls = new List<NewGroup>();
            mainLabels = new List<Label> { lbl_itemMyday, lbl_itemImportant, lbl_itemTasks, lbl_itemCompleted };
            SelectLabel(lbl_itemMyday);
            showAllGroup();
        }

        private void SelectLabel(Label label)
        {
            foreach (NewGroup group in groupControls)
            {
                group.Deselect();
            }

            if (selectedLabel != null)
            {
                selectedLabel.BackColor = Color.White;
                selectedLabel.Font = new Font(selectedLabel.Font, FontStyle.Regular);
            }

            selectedLabel = label;
            selectedLabel.BackColor = Color.FromArgb(228, 237, 255);
            selectedLabel.Font = new Font(selectedLabel.Font, FontStyle.Bold);
        }

        private void lbl_itemMyday_MouseEnter(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemMyday)
            {
                lbl_itemMyday.BackColor = Color.FromArgb(246, 246, 246);
            }

        }

        private void lbl_itemMyday_MouseLeave(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemMyday)
            {
                lbl_itemMyday.BackColor = Color.White;
            }
        }

        private void lbl_itemImportant_MouseEnter(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemImportant)
            {
                lbl_itemImportant.BackColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void lbl_itemImportant_MouseLeave(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemImportant)
            {
                lbl_itemImportant.BackColor = Color.White;
            }
        }

        private void lbl_itemTasks_MouseEnter(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemTasks)
            {
                lbl_itemTasks.BackColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void lbl_itemTasks_MouseLeave(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemTasks)
            {
                lbl_itemTasks.BackColor = Color.White;
            }
        }

        private void lbl_itemCompleted_MouseEnter(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemCompleted)
            {
                lbl_itemCompleted.BackColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void lbl_itemCompleted_MouseLeave(object sender, EventArgs e)
        {
            if (selectedLabel != lbl_itemCompleted)
            {
                lbl_itemCompleted.BackColor = Color.White;
            }
        }

        private void lbl_itemNewGroup_MouseEnter(object sender, EventArgs e)
        {
            lbl_itemNewGroup.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void lbl_itemNewGroup_MouseLeave(object sender, EventArgs e)
        {
            lbl_itemNewGroup.BackColor = Color.White;
        }

        private void lbl_itemMyday_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("User information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectLabel(lbl_itemMyday);
            Myday md = new Myday(user);
            main.setForm(md);
        }

        private void lbl_itemImportant_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("User information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectLabel(lbl_itemImportant);
            Important imp = new Important(user);
            main.setForm(imp);
        }

        private void lbl_itemTasks_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("User information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectLabel(lbl_itemTasks);
            Tasks tasks = new Tasks(user);
            main.setForm(tasks);
        }

        private void lbl_itemCompleted_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("User information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectLabel(lbl_itemCompleted);
            Completed completed = new Completed(user);
            main.setForm(completed);
        }

        private void lbl_itemNewGroup_Click(object sender, EventArgs e)
        {
            pnlitem_GroupName.Visible = true;
            txtItem_GroupName.Focus();
            txtItem_GroupName.PlaceholderText = "Name of group";
        }

        private void txtItem_GroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string groupName = txtItem_GroupName.Text.Trim();
                bool check = groupBUS.checkGroupTitleExistence(groupName, user.UserID);
                if (!string.IsNullOrEmpty(groupName) && !check)
                {
                    AddGroup(groupName);
                    txtItem_GroupName.Clear();
                    pnlitem_GroupName.Visible = false;
                } else
                {
                    MessageBox.Show("Group's name has existed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                e.Handled = true;
                e.SuppressKeyPress = true; // Ngăn chặn tiếng beep khi nhấn Enter
            }
        }

        private void AddGroup(string groupName)
        {
            try
            {
                GroupDTO groupDTO = new GroupDTO
                {
                    Title = txtItem_GroupName.Text,
                    CreatedBy = user.UserID,
                    CreatedDate = DateTime.Now
                };
                NewGroup newGroup = new NewGroup(groupName, user, main, groupControls, mainLabels, groupDTO, this);
                bool test = groupBUS.insert(groupDTO);
                GroupMemberShipDTO groupMemberShipDTO = new GroupMemberShipDTO
                {
                    GroupID = groupDTO.GroupID,
                    UserID = user.UserID,
                    JoinedDate = DateTime.Now
                };
                bool testMemberShip = membershipBUS.insert(groupMemberShipDTO);
                
                if (test && testMemberShip)
                {
                    //groups = groupBUS.getAllByUserID(user.UserID); 
                    pnlMenu_bottom.Controls.Add(newGroup); // Them vao panel
                    groupControls.Add(newGroup); // Thêm vào danh sách quản lý
                    newGroup.Click += Group_Click; // Gắn sự kiện click
                }
                else
                {
                    MessageBox.Show("Task added fail!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting task: " + ex.Message);
            }
        }

        private void Group_Click(object? sender, EventArgs e)
        {
            if (sender is NewGroup selectedGroup)
            {
                foreach (Label label in mainLabels)
                {
                    label.BackColor = Color.White;
                    label.Font = new Font(label.Font, FontStyle.Regular);
                }

                foreach (NewGroup group in groupControls)
                {
                    group.Deselect();
                }

                selectedGroup.SelectGroup();

            }
        }

        public void showAllGroup() 
        {
            groups = groupBUS.getAllByUserID(user.UserID);
            if (groups != null)
            {
                foreach (GroupDTO groupDTO in groups)
                {
                    NewGroup newGroup = new NewGroup(groupDTO.Title, user, main, groupControls, mainLabels, groupDTO, this);
                    pnlMenu_bottom.Controls.Add(newGroup);
                    groupControls.Add(newGroup); // Thêm vào danh sách quản lý
                    newGroup.Click += Group_Click; // Gắn sự kiện click
                }
            }
        }

        public void RefreshGroupList(object? sender, EventArgs e)
        {
            pnlMenu_bottom.Controls.Clear(); 
            groupControls.Clear();           
            groups = groupBUS.getAllByUserID(user.UserID);
            showAllGroup();

            SelectLabel(lbl_itemMyday);
            Myday md = new Myday(user);
            main.setForm(md);
        }
    }
}
