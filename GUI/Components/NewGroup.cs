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

namespace GUI.Components
{
    public partial class NewGroup : UserControl
    {
        private Label selectedLabel;
        private UserDTO user;
        private Main main;
        private List<NewGroup> allGroups;
        private List<Label> mainLabels;
        private GroupDTO group;
        
        public NewGroup(string nameGroup, UserDTO user, Main main, List<NewGroup> allGroups, List<Label> mainLabels, GroupDTO group)
        {
            this.user = user;
            this.main = main;
            this.allGroups = allGroups;
            InitializeComponent();
            lblItemGroup.Text = nameGroup;
            this.mainLabels = mainLabels;
            this.mainLabels = mainLabels;
            this.group = group;
        }

        //private void SelectLabel(Label label)
        //{
        //    if (selectedLabel != null)
        //    {
        //        selectedLabel.BackColor = Color.White;
        //        selectedLabel.Font = new Font(selectedLabel.Font, FontStyle.Regular);
        //    }

        //    selectedLabel = label;
        //    selectedLabel.BackColor = Color.FromArgb(228, 237, 255);
        //    selectedLabel.Font = new Font(selectedLabel.Font, FontStyle.Bold);
        //}


        public string getlblItemGroup()
        {
            return this.lblItemGroup.Text;
        }
        private void lblItemGroup_MouseEnter(object sender, EventArgs e)
        {
            
            if (!IsSelected())
            {
                lblItemGroup.BackColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void lblItemGroup_MouseLeave(object sender, EventArgs e)
        {
            if (!IsSelected())
            {
                lblItemGroup.BackColor = Color.White;
            }
        }

        private void lblItemGroup_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("User information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Label label in mainLabels)
            {
                label.BackColor = Color.White;
                label.Font = new Font(label.Font, FontStyle.Regular);
            }

            foreach (NewGroup group in allGroups)
            {
                group.Deselect();
            }

            SelectGroup();

            Group newGroup = new Group(user, group);
            //Console.WriteLine(group.ToString());
            main.setForm(newGroup);
        }

        internal void Deselect()
        {
            lblItemGroup.BackColor = Color.White;
            lblItemGroup.Font = new Font(lblItemGroup.Font.FontFamily, lblItemGroup.Font.Size, FontStyle.Regular);
        }

        internal void SelectGroup()
        {
            lblItemGroup.BackColor = Color.FromArgb(228, 237, 255);
            lblItemGroup.Font = new Font(lblItemGroup.Font.FontFamily, lblItemGroup.Font.Size, FontStyle.Bold);
        }

        private bool IsSelected()
        {
            return lblItemGroup.BackColor == Color.FromArgb(228, 237, 255);
        }
    }
}
