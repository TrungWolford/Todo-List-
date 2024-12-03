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
        private UserDTO user;

        

        public Main(UserDTO user)
        {
            this.user = user;
            InitializeComponent();
            menuTaskBar = new MenuTaskBar(this, user);
            menuTaskBar.TopLevel = false;
            pnlMenutaskbar.Controls.Add(menuTaskBar);
            menuTaskBar.Dock = DockStyle.Fill;
            menuTaskBar.Show();

            myday = new Myday(user);
            myday.TopLevel = false;
            pnlMainContent.Controls.Add(myday);
            myday.Dock = DockStyle.Fill;
            myday.Show();

            this.StartPosition = FormStartPosition.CenterScreen;
            string username = user.UserName.ToString();
        }

        

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
    }
}
