using BUS;
using DAO;
using DTO;
using GUI.Components;
using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Panel
{
    public partial class Member : Form
    {
        //public event Action OnMemberExit;
        private GroupDTO groupDTO;
        private UserDTO userDTO;
        private List<GroupMemberShipDTO> members;
        private GroupMemberShipBUS groupMemberShipBUS;
        private UserBUS userBUS;
        private GroupBUS groupBUS;
        public Member(GroupDTO groupDTO, UserDTO userDTO)
        {
            this.groupDTO = groupDTO;
            this.userDTO = userDTO;
            groupMemberShipBUS = new GroupMemberShipBUS();
            userBUS = new UserBUS();
            groupBUS = new GroupBUS();
            members = groupMemberShipBUS.getAllMemberByGroupID(groupDTO.GroupID);
            InitializeComponent();
            showAllMember();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool checkValidation()
        {
            if (Validation.isEmpty(txtUsername_invite.Text))
            {
                MessageBox.Show("Please fill in User's Username!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ResetForm()
        {
            txtUsername_invite.Clear();
        }

        private void btnInvite_member_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValidation())
                {
                    string userName = txtUsername_invite.Text;
                    bool check = userBUS.findUserByUsername(userName);
                    if (check)
                    {
                        try
                        {
                            int userID = userBUS.selectedUserByName(userName).UserID;
                            bool checkUserExist = groupMemberShipBUS.userExistion(userID, groupDTO.GroupID);

                            if (!checkUserExist)
                            {
                                GroupMemberShipDTO groupMemberShipDTO = new GroupMemberShipDTO
                                {
                                    GroupID = groupDTO.GroupID,
                                    UserID = userID,
                                    JoinedDate = DateTime.Now
                                };
                                bool checkInsert = groupMemberShipBUS.insert(groupMemberShipDTO);
                                if (checkInsert)
                                {
                                    members.Add(groupMemberShipDTO);
                                    ResetForm();
                                    MessageBox.Show("User added successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("User added fail!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("User has already exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error while inserting group membership: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User is not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting group membership: " + ex.Message);
            }
        }

        private void showAllMember()
        {
            if (members.Count > 0)
            {
                foreach (GroupMemberShipDTO member in members)
                {
                    UserDTO userDTO = userBUS.selectUserByID(member.UserID);
                    if (userDTO != null)
                    {
                        if (userDTO.UserID == groupDTO.CreatedBy)
                        {
                            cpGroupMembers cpGroupMembers = new cpGroupMembers(userDTO.UserName, "Owner", groupDTO);
                            pnlMember_owner.Controls.Add(cpGroupMembers);
                        }
                        else
                        {
                            cpGroupMembers cpGroupMembers = new cpGroupMembers(userDTO.UserName, "Member", groupDTO);
                            pnlCenter_member.Controls.Add(cpGroupMembers);
                        }
                    }
                    else
                    {
                        return;
                    }

                }
            }
        }

        private void lblExit_member_MouseEnter(object sender, EventArgs e)
        {
            lblExit_member.BackColor = Color.FromArgb(228, 237, 255);
        }

        private void lblExit_member_MouseLeave(object sender, EventArgs e)
        {
            lblExit_member.BackColor = Color.White;
        }

        private void lblExit_member_Click(object sender, EventArgs e)
        {
            bool check = groupMemberShipBUS.removeUserByID(userDTO.UserID, groupDTO.GroupID);
            //bool checkGroup = groupBUS.removeUserGroupByID(groupDTO);
            if (check)
            {
                MessageBox.Show("Succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //OnMemberExit?.Invoke(); // Gọi sự kiện sau khi thành công
                this.Close();
            } else
            {
                MessageBox.Show("Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
