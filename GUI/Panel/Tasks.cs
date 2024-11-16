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
    public partial class Tasks : Form
    {
        private MonthCalendar calendar;
        public Tasks()
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
            lblTasks_calendar.Text = e.Start.ToString("dd/MM/yyyy");
            lblTasks_important.Left = lblTasks_calendar.Right + 20;
            calendar.Visible = false;
        }

        private void lblTasks_calendar_Click(object sender, EventArgs e)
        {
            calendar.Location = new Point(lblTasks_calendar.Left + 70, lblTasks_calendar.Bottom + 180);
            calendar.BringToFront();
            calendar.Visible = true;
        }
    }
}
