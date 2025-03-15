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

namespace GUI.Components
{
    public partial class chatBot : UserControl
    {
        public chatBot()
        {
            InitializeComponent();
                    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChatBotForm chatBot = new ChatBotForm();
            chatBot.ShowDialog();
        }
    }
}
