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
            SelectLabel(lbl_itemMyday);
        }

        private void SelectLabel(Label label)
        {
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

        
    }
}
