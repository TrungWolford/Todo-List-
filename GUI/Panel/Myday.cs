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
        private UserDTO user;

        public Myday(UserDTO user)
        {
            this.user = user;
            InitializeComponent();

            taskBUS = new TaskBUS();
            listTasks = taskBUS.getAllTaskCurrentDate(user.UserID);
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
                        CreatedBy = user.UserID
                    };
                    bool test = taskBUS.insert(newTask);
                    if (test)
                    {
                        MessageBox.Show("Task added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listTasks = taskBUS.getAllTaskCurrentDate(user.UserID);
                        loadDataTable(listTasks);
                    }
                    else
                    {
                        MessageBox.Show("Task added fail!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting task: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            txtMydayTask.Clear();
            lblMd_calendar.Text = "";
            lblMd_important.Visible = true;
            lblMd_importantSelected.Visible = false;
            isImportant = false;
            lblMd_importantSelected.Location = new Point(67, 51);
            lblMd_important.Location = new Point(67, 51);
        }

        private void loadDataTable(List<TaskDTO> tasks)
        {
            if (tasks == null || tasks.Count == 0)
            {
                tableMyday.Rows.Clear();
                return;
            }

            tableMyday.Rows.Clear();

            foreach (var task in tasks)
            {
                int rowIndex = tableMyday.Rows.Add();

                tableMyday.Rows[rowIndex].Cells["clTitle_md"].Value = task.Title;
                tableMyday.Rows[rowIndex].Cells["clDuedate_md"].Value = task.DueDate.ToString("dd/MM/yyyy");
                if (!task.IsImportant)
                {
                    tableMyday.Rows[rowIndex].Cells["clImportance_md"].Value = Properties.Resources.Important_24px;
                }
                else
                {
                    tableMyday.Rows[rowIndex].Cells["clImportance_md"].Value = Properties.Resources.ImportantSelected_24px;
                }
                if (task.CompletedDate == null)
                {
                    tableMyday.Rows[rowIndex].Cells["clDone_md"].Value = Properties.Resources.notDone_24;
                }
                else
                {
                    tableMyday.Rows[rowIndex].Cells["clDone_md"].Value = Properties.Resources.done_24;
                }
            }
        }

        private void tableMyday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tableMyday.Columns["clImportance_md"].Index)
            {
                try
                {
                    var selectedTask = listTasks[e.RowIndex];
                    var index = listTasks.FindIndex(t => t.TaskID == selectedTask.TaskID);

                    bool previousState = selectedTask.IsImportant;
                    selectedTask.IsImportant = !selectedTask.IsImportant;

                    bool check = taskBUS.update(selectedTask);

                    if (check)
                    {
                        listTasks[index].IsImportant = !previousState;

                        tableMyday.Refresh();
                        loadDataTable(listTasks);
                    }
                    else
                    {
                        selectedTask.IsImportant = previousState;
                        MessageBox.Show("Failed to update task.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == tableMyday.Columns["clDone_md"].Index)
            {
                try
                {
                    var selectedTask = listTasks[e.RowIndex];
                    var index = listTasks.FindIndex(t => t.TaskID == selectedTask.TaskID);

                    DateTime? previousDate = selectedTask.CompletedDate;

                    selectedTask.CompletedDate = previousDate == null ? DateTime.Now : (DateTime?)null;

                    bool check = taskBUS.update(selectedTask);
                    if (check)
                    {
                        listTasks[index].CompletedDate = selectedTask.CompletedDate;
                        if (selectedTask.CompletedDate != null)
                        {
                            tableMyday.Rows.RemoveAt(e.RowIndex);
                            listTasks.RemoveAt(index);
                        }
                        listTasks = taskBUS.getAllTaskCurrentDate(user.UserID);
                        loadDataTable(listTasks);
                    }
                    else
                    {
                        selectedTask.CompletedDate = previousDate;
                        MessageBox.Show("Failed to update task completion.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Myday_Load(object sender, EventArgs e)
        {
            if (tableMyday.Columns.Count == 0)
            {
                tableMyday.Columns.Add("clTitle_md", "Title");
                tableMyday.Columns.Add("clDuedate_md", "Due Date");
                tableMyday.Columns.Add("clImportance_md", "Important");
                tableMyday.Columns.Add("clDone_md", "Done");
            }
            Console.WriteLine(listTasks.Count);
            loadDataTable(listTasks);
        }

        public void PerformSearch(string searchText)
        {

            List<TaskDTO> filteredTasks = listTasks
                                .Where(task =>
                                    task.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                    (task.Description != null && task.Description.Contains(searchText, StringComparison.OrdinalIgnoreCase)))
                                .ToList();

            // Hiển thị danh sách task đã lọc

            List<TaskDTO> newList = new List<TaskDTO>();
            foreach (var task in filteredTasks)
            {
                newList.Add(task);
                Console.WriteLine(task);
            }

            Console.WriteLine(newList.Count);
            loadDataTable(newList);
        }
    }

}
