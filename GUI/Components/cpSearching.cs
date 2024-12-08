using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Panel;

namespace GUI.Components
{
    public partial class cpSearching : UserControl
    {

        public event EventHandler<string> OnSearchTextChanged; // Su kien tuy chinh
        public Tasks tasks;

        public cpSearching()
        {
            InitializeComponent();

            // Thiet lap placeholder ban dau
            txt_search.Text = "Search";
            txt_search.ForeColor = Color.Gray;
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search")
            {
                txt_search.Text = string.Empty;
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                txt_search.Text = "Search";
                txt_search.ForeColor = Color.Gray;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "Search")
            {
                OnSearchTextChanged?.Invoke(this, txt_search.Text);
            }
        }

        private void cpSearching_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
