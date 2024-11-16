using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Panel
{
    public partial class Important : Form
    {
        private MonthCalendar calendar;
        public Important()
        {
            InitializeComponent();
            calendar = new MonthCalendar
            {
                Visible = false,
                MaxSelectionCount = 1
            };
            calendar.DateSelected += Calendar_DateSelected;
            Controls.Add(calendar);
        }
        private void Calendar_DateSelected(object? sender, DateRangeEventArgs e)
        {
            lblImp_calendar.Text = e.Start.ToString("dd/MM/yyyy");
            lblImp_important.Left = lblImp_calendar.Right + 20;
            calendar.Visible = false;
        }

        private void lblImp_calendar_Click(object sender, EventArgs e)
        {
            calendar.Location = new Point(lblImp_calendar.Left + 70, lblImp_calendar.Bottom + 180);
            calendar.BringToFront();
            calendar.Visible = true;
        }
    }
}
