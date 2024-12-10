using DTO;
using GUI.Components;
using GUI.Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {

        private MenuTaskBar menuTaskBar;
        private Myday myday;
        private Tasks tasks;
        private Important important;
        private Completed completed;
        private UserDTO user;


        public Main(UserDTO user)
        {
            this.user = user;
            InitializeComponent();
            menuTaskBar = new MenuTaskBar(this, user);
            //menuTaskBar.showAllGroup();
            menuTaskBar.TopLevel = false;
            pnlMenutaskbar.Controls.Add(menuTaskBar);
            menuTaskBar.Dock = DockStyle.Fill;
            menuTaskBar.Show();           

            myday = new Myday(user);
            important = new Important(user);
            tasks = new Tasks(user);
            completed = new Completed(user);

            myday.TopLevel = false;
            pnlMainContent.Controls.Add(myday);
            myday.Dock = DockStyle.Fill;
            myday.Show();

            cpSearching1.OnSearchTextChanged -= CpSearching1_OnSearchTextChanged;
            cpSearching1.OnSearchTextChanged += CpSearching1_OnSearchTextChanged;


            this.StartPosition = FormStartPosition.CenterScreen;
            string username = user.UserName.ToString();
        }

        // test <<<
        private void ShowForm(Form formToShow)
        {
            if (pnlMainContent.Controls.Count > 0)
            {
                pnlMainContent.Controls.Clear();
                formToShow.TopLevel = false;
                formToShow.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(formToShow);
                formToShow.Show();
            }
        }
        // >>>


        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setForm(Form form)
        {
            pnlMainContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(form);
            form.Show();
            pnlMainContent.Refresh();
        }

        private void cpSearching1_Load(object sender, EventArgs e)
        {


        }

        private void CpSearching1_OnSearchTextChanged(object sender, string searchText)
        {   
            if (pnlMainContent.Controls.Count > 0)
            {
                Form activeForm = pnlMainContent.Controls[0] as Form;
                if (activeForm is Myday mydayForm)
                {
                    mydayForm.PerformSearch(searchText);
                } else if (activeForm is Tasks tasksForm)
                {
                    tasksForm.PerformSearch(searchText);
                } else if (activeForm is Important importantForm)
                {
                    importantForm.PerformSearch(searchText);
                } else if (activeForm is Completed completedForm)
                {
                    completedForm.PerformSearch(searchText);
                } else if (activeForm is Group groupForm)
                {
                    groupForm.PerformSearch(searchText);
                }
            }

            
        }
    }
}
