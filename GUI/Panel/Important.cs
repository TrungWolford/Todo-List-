using BUS;
using DTO;
using Helper;
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
        private UserDTO user;
        private bool isImportant;
        public TaskBUS taskBUS;
        public List<TaskDTO> listTasks;
        public Important(UserDTO user)
        {
            this.user = user;
            InitializeComponent();

            taskBUS = new TaskBUS();
            listTasks = taskBUS.getAllTaskImportant(user.UserID);
            isImportant = true;

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
            calendar.Visible = false;
        }

        private void lblImp_calendar_Click(object sender, EventArgs e)
        {
            calendar.Location = new Point(lblImp_calendar.Left + 70, lblImp_calendar.Bottom + 180);
            calendar.BringToFront();
            calendar.Visible = true;
        }

        private bool checkValidation()
        {
            if (Validation.isEmpty(lblImp_calendar.Text))
            {
                MessageBox.Show("Please select a date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Validation.isEmpty(txtImportantTask.Text))
            {
                MessageBox.Show("Please set the title of task", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnImp_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValidation())
                {
                    string dateString = lblImp_calendar.Text;
                    TaskDTO newTask = new TaskDTO
                    {
                        Title = txtImportantTask.Text,
                        DueDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        IsImportant = isImportant,
                        CreatedDate = DateTime.Now,
                        CreatedBy = user.UserID
                    };
                    bool test = taskBUS.insert(newTask);
                    if (test)
                    {
                        MessageBox.Show("Task added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listTasks = taskBUS.getAllTaskImportant(user.UserID);
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
            txtImportantTask.Clear();
            lblImp_calendar.Text = "";
            isImportant = true;
        }

        private void Important_Load(object sender, EventArgs e)
        {
            if (tableImportant.Columns.Count == 0)
            {
                tableImportant.Columns.Add("clTitle_imp", "Title");
                tableImportant.Columns.Add("clDuedate_imp", "Due Date");
                tableImportant.Columns.Add("clImportance_imp", "Important");
                tableImportant.Columns.Add("clDone_imp", "Done");
            }

            loadDataTable(listTasks);
        }

        private void loadDataTable(List<TaskDTO> tasks)
        {
            if (tasks == null || tasks.Count == 0)
            {
                return;
            }

            tableImportant.Rows.Clear();

            foreach (var task in tasks)
            {
                int rowIndex = tableImportant.Rows.Add();

                tableImportant.Rows[rowIndex].Cells["clTitle_imp"].Value = task.Title;
                tableImportant.Rows[rowIndex].Cells["clDuedate_imp"].Value = task.DueDate.ToString("dd/MM/yyyy");
                if (!task.IsImportant)
                {
                    tableImportant.Rows[rowIndex].Cells["clImportance_imp"].Value = Properties.Resources.Important_24px;
                }
                else
                {
                    tableImportant.Rows[rowIndex].Cells["clImportance_imp"].Value = Properties.Resources.ImportantSelected_24px;
                }
                if (task.CompletedDate == null)
                {
                    tableImportant.Rows[rowIndex].Cells["clDone_imp"].Value = Properties.Resources.notDone_24;
                }
                else
                {
                    //tableImportant.Rows[rowIndex].Cells["clDone_imp"].Value = Properties.Resources.done_24;
                }
            }
        }

        private void tableImportant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tableImportant.Columns["clImportance_imp"].Index)
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
                        if (!selectedTask.IsImportant)
                        {
                            tableImportant.Rows.RemoveAt(e.RowIndex);
                            listTasks.RemoveAt(index);
                        }
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
            else if (e.RowIndex >= 0 && e.ColumnIndex == tableImportant.Columns["clDone_imp"].Index)
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
                            tableImportant.Rows.RemoveAt(e.RowIndex);
                            listTasks.RemoveAt(index);
                        }
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
    }
}
