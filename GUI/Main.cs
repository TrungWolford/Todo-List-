using GUI.Components;
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

namespace GUI
{
    public partial class Main : Form
    {
        private MenuTaskBar menuTaskBar;
        private Myday myday;
        public Main()
        {
            InitializeComponent();

            menuTaskBar = new MenuTaskBar(this);
            menuTaskBar.TopLevel = false; 
            pnlMenutaskbar.Controls.Add(menuTaskBar);
            menuTaskBar.Dock = DockStyle.Fill;
            menuTaskBar.Show();

            myday = new Myday();
            myday.TopLevel = false;
            pnlMainContent.Controls.Add(myday);
            myday.Dock = DockStyle.Fill;
            myday.Show();

            this.StartPosition = FormStartPosition.CenterScreen;
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
