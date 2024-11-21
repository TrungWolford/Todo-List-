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
using DTO;
using Helper;
using BUS;

namespace GUI.Panel
{
    public partial class Myday : Form
    {
        private MonthCalendar calendar;
        private bool isImportant;
        public TaskBUS taskBUS;
        public List<TaskDTO> listTasks;

        public Myday()
        {
            InitializeComponent();

            taskBUS = new TaskBUS();
            listTasks = taskBUS.GetAll();
            isImportant = false;

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
            lblMd_calendar.Text = e.Start.ToString("dd/MM/yyyy");
            lblMd_important.Left = lblMd_calendar.Right + 20;
            lblMd_importantSelected.Left = lblMd_calendar.Right + 20;
            calendar.Visible = false;
        }

        private void lblMd_calendar_Click(object sender, EventArgs e)
        {
            calendar.Location = new Point(lblMd_calendar.Left + 70, lblMd_calendar.Bottom + 180);
            calendar.BringToFront();
            calendar.Visible = true;
        }

        private void lblMd_important_Click(object sender, EventArgs e)
        {
            lblMd_important.Visible = false;
            lblMd_importantSelected.Visible = true;
            isImportant = true;
        }

        private void lblMd_importantSelected_Click(object sender, EventArgs e)
        {
            lblMd_important.Visible = true;
            lblMd_importantSelected.Visible = false;
            isImportant = false;
        }

        private bool checkValidation()
        {
            if (Validation.isEmpty(lblMd_calendar.Text))
            {
                MessageBox.Show("Please select a date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Validation.isEmpty(txtMydayTask.Text))
            {
                MessageBox.Show("Please set the title of task", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnMd_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValidation())
                {
                    string dateString = lblMd_calendar.Text;
                    TaskDTO newTask = new TaskDTO
                    {
                        Title = txtMydayTask.Text,
                        DueDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        IsImportant = isImportant,
                        CreatedDate = DateTime.Now,
                        CreatedBy = 1
                    };
                    taskBUS.insert(newTask);
                    MessageBox.Show("Task added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine(newTask);
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Error while inserting task: " + ex.Message);
            }
        }
    }
}
