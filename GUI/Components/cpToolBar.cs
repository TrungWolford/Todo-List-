﻿using GUI.Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.Components
{

    public partial class cpToolBar : UserControl
    {

        public delegate void SortByChangedHandler(string sortBy);
        public event SortByChangedHandler OnSortByChanged;

        public List<TaskDTO> listTasks;
        public List<UserDTO> listUser;
        private UserDTO userDTO;
        private TaskDTO taskDTO;
        public Tasks taskForm;
        private sortBUS sortBUS = new sortBUS();
        

        public cpToolBar()
        {
            InitializeComponent();
            UpdateCurrentTime();
        }

        public cpToolBar(Form form)
        {
            InitializeComponent();
            UpdateCurrentTime();
            UpdateTitle(form);
        }

        private void UpdateTitle(Form formChild)
        {
            if (formChild is Myday)
            {
                lblTop_title.Text = "My day";
            }
            else if (formChild is Important)
            {
                lblTop_title.Text = "Important";
            }
            else if (formChild is Tasks)
            {
                lblTop_title.Text = "Tasks";
            }
            else if (formChild is Completed)
            {
                lblTop_title.Text = "Completed";
            } else
            {
                lblTop_title.Text = "";
            }
        }

        private void UpdateCurrentTime()
        {
            lblTop_currentTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        private void lblTop_arrange_Click(object sender, EventArgs e)
        {
            if (pnlArrangeBar.Visible == false)
            {
                pnlArrangeBar.Visible = true;
            }
            else
            {
                pnlArrangeBar.Visible = false;
            }
        }
        private void lbl_itemSortby_importance_MouseEnter(object sender, EventArgs e)
        {
            lbl_itemSortby_importance.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void lbl_itemSortby_importance_MouseLeave(object sender, EventArgs e)
        {
            lbl_itemSortby_importance.BackColor = Color.White;
        }
        private void lbl_itemSortby_Duedate_MouseEnter(object sender, EventArgs e)
        {
            lbl_itemSortby_Duedate.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void lbl_itemSortby_Duedate_MouseLeave(object sender, EventArgs e)
        {
            lbl_itemSortby_Duedate.BackColor = Color.White;
        }
        private void lbl_itemSortby_Alphabetically_MouseEnter(object sender, EventArgs e)
        {
            lbl_itemSortby_Alphabetically.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void lbl_itemSortby_Alphabetically_MouseLeave(object sender, EventArgs e)
        {
            lbl_itemSortby_Alphabetically.BackColor = Color.White;
        }
        private void lbl_itemSortby_Creationdate_MouseEnter(object sender, EventArgs e)
        {
            lbl_itemSortby_Creationdate.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void lbl_itemSortby_Creationdate_MouseLeave(object sender, EventArgs e)
        {
            lbl_itemSortby_Creationdate.BackColor = Color.White;
        }

        private void cb_Sortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cb_Sortby.Text.Trim();
            OnSortByChanged?.Invoke(selectedValue);
        }

        
    }
}
