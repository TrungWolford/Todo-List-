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

namespace GUI.Components
{
    public partial class CustomeDateTime : UserControl
    {
        public event EventHandler<DateTime> OnCustomDateTime_Choosed;
        private Form form;
        public CustomeDateTime()
        {
            InitializeComponent();
        }
        public CustomeDateTime(Form form)
        {
            this.form = form;
            InitializeComponent();
            this.Visible = false;

            monthCalendar_Custome = new MonthCalendar
            {
                Visible = false,
                MaxSelectionCount = 1
            };

            monthCalendar_Custome.DateSelected += monthCalendar_DateSelected;
            Controls.Add(monthCalendar_Custome);
        }

        private void monthCalendar_DateSelected(object? sender, DateRangeEventArgs e)
        {
            UpdateDateTimeLabel(e.Start);
        }



        private void btn_CustomeClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_CustomeDone_Click(object sender, EventArgs e)
        {
            // Kiểm tra và gửi giá trị ngày giờ đã chọn
            if (DateTime.TryParseExact(lbl_CustomeHourMinute.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime chosenDateTime))
            {
                OnCustomDateTime_Choosed?.Invoke(this, chosenDateTime);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please fill in the date and time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_CustomeMinute_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimeLabel(monthCalendar_Custome.SelectionStart);

        }

        private void txt_CustomeHour_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimeLabel(monthCalendar_Custome.SelectionStart);
        }

        private void UpdateDateTimeLabel(DateTime selectedDate)
        {
            // Lấy giá trị giờ
            int hour = 0;
            if (!string.IsNullOrWhiteSpace(txt_CustomeHour.Text) && int.TryParse(txt_CustomeHour.Text, out int parsedHour))
            {
                hour = Math.Clamp(parsedHour, 0, 23); // Giới hạn từ 0-23
            }

            // Lấy giá trị phút
            int minute = 0;
            if (!string.IsNullOrWhiteSpace(txt_CustomeMinute.Text) && int.TryParse(txt_CustomeMinute.Text, out int parsedMinute))
            {
                minute = Math.Clamp(parsedMinute, 0, 59); // Giới hạn từ 0-59
            }

            DateTime customDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, minute, 0);
            lbl_CustomeHourMinute.Text = customDateTime.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
