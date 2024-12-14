using BUS;
using DTO;
using GUI.Components;
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
        private bool isSelectedReminder;
        public Important(UserDTO user)
        {
            this.user = user;
            InitializeComponent();

            taskBUS = new TaskBUS();
            listTasks = taskBUS.getAllTaskImportant(user.UserID);
            isImportant = true;
            isSelectedReminder = false;

            customeDateTime1.OnCustomDateTime_Choosed += OnTimePicker_Choosed;


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
            lblImp_timePicker.Left = lblImp_calendar.Right + 75;
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
                    
                    TaskDTO newTask;
                    string dateString = lblImp_calendar.Text;
                    if (isSelectedReminder)
                    {
                        string dataTimeString = lblImp_timePicker.Text;
                        newTask = new TaskDTO
                        {
                            Title = txtImportantTask.Text,
                            DueDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            IsImportant = isImportant,
                            CreatedDate = DateTime.Now,
                            CreatedBy = user.UserID,
                            ReminderTime = DateTime.ParseExact(dataTimeString, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),

                            IsReminderSent = false
                        };
                    }
                    else
                    {
                        newTask = new TaskDTO
                        {
                            Title = txtImportantTask.Text,
                            DueDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            IsImportant = isImportant,
                            CreatedDate = DateTime.Now,
                            CreatedBy = user.UserID,
                            IsReminderSent = false
                        };
                    }
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

        public void loadDataTable2(string selectedValue, List<TaskDTO> tasks)
        {

            tasks = listTasks;
            int currentUserID = user.UserID;
            var userTasks = tasks.Where(t => t.CreatedBy == currentUserID).ToList();

            // Sắp xếp các task theo các tiêu chí khác nhau
            var sortedTaskImportance = userTasks.OrderByDescending(t => t.IsImportant).ToList();
            var sortedTaskDueDate = userTasks.OrderBy(t => t.DueDate).ToList();
            var sortedTaskAlpha = userTasks.OrderBy(t => t.Title).ToList();
            var sortedTaskByCreateDate = userTasks.OrderBy(t => t.CreatedDate).ToList();

            List<TaskDTO> sortedTasks = new List<TaskDTO>();

            if (selectedValue == "Importance")
            {
                sortedTasks = sortedTaskImportance;
            }
            else if (selectedValue == "Due date")
            {
                sortedTasks = sortedTaskDueDate;
            }
            else if (selectedValue == "Alphabetically")
            {
                sortedTasks = sortedTaskAlpha;
            }
            else if (selectedValue == "Creation Date")
            {
                sortedTasks = sortedTaskByCreateDate;
            }
            else
            {
                sortedTasks = tasks;
            }

            loadDataTable(sortedTasks);
        }

        private void loadDataTable(List<TaskDTO> tasks)
        {
            if (tasks == null || tasks.Count == 0)
            {
                tableImportant.Rows.Clear();
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
                        listTasks = taskBUS.getAllTaskImportant(user.UserID);
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
        private void tableImportant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = tableImportant.Columns[e.ColumnIndex].Name;
                object cellValue = tableImportant.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                var selectedTask = listTasks[e.RowIndex];
                int taskid = selectedTask.TaskID;

                TaskInfo taskInfoForm = new TaskInfo(taskid, user);
                taskInfoForm.OnTaskInfoUpdate += TaskInfo_OnTaskInfoUpdate;
                taskInfoForm.ShowDialog();
            }
        }

        public void TaskInfo_OnTaskInfoUpdate(object sender, EventArgs e)
        {
            listTasks = taskBUS.getAllTaskImportant(user.UserID);
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

        private void CpToolBar_OnSortByChanged(string sortBy)
        {
            loadDataTable2(sortBy, listTasks);
        }

        private void cpToolBar_Load(object sender, EventArgs e)
        {
            // Đăng ký sự kiện OnSortByChanged
            cpToolBar.OnSortByChanged -= CpToolBar_OnSortByChanged;
            cpToolBar.OnSortByChanged += CpToolBar_OnSortByChanged;
        }

        private void lblImp_timePicker_Click(object sender, EventArgs e)
        {
            customeDateTime1.Visible = true;
        }
        private void OnTimePicker_Choosed(object sender, DateTime dateTime)
        {
            if (sender is CustomeDateTime)
            {
                lblImp_timePicker.Text = dateTime.ToString("dd/MM/yyyy h:mm:ss tt");
                isSelectedReminder = true;
            }
        }
    }
}
