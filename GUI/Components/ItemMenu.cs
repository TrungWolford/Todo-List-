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
    public partial class ItemMenu : UserControl
    {

        public ItemMenu(string pathIcon, string text)
        {
            InitializeComponent(pathIcon, text);
        }

        private void ItemMenu_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(228, 237, 255);
        }
    }
}
