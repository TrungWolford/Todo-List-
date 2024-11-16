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
    public partial class cpToolBar : UserControl
    {
       
        public cpToolBar()
        {
            InitializeComponent();
            UpdateCurrentTime();
            //UpdateTitle();
        }

        public cpToolBar(Form form) {
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
            } else
            {
                lblTop_title.Text = "";
            }
        }

        private void UpdateCurrentTime()
        {
            lblTop_currentTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }
    }
}
