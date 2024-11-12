using GUI.Components;
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
        public Main()
        {
            InitializeComponent();
            menuTaskBar = new MenuTaskBar(this);
            menuTaskBar.TopLevel = false; 
            pnlMenutaskbar.Controls.Add(menuTaskBar);
            menuTaskBar.Dock = DockStyle.Fill;
            menuTaskBar.Show(); 
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
