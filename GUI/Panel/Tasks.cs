using BUS;
using DAO;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Panel
{
    public partial class Tasks : Form
    {
        private MonthCalendar calendar;
        private UserDTO user;
        private bool isImportant;
        //private DateTime? completedDate;
        public TaskBUS taskBUS;
        public List<TaskDTO> listTasks;
        public sortBUS sortBUS = new sortBUS();
        

        public Tasks(UserDTO user)
        {
            this.user = user;
            InitializeComponent();

            taskBUS = new TaskBUS();
            listTasks = taskBUS.getAllByUserID(user.UserID);
            isImportant = false;
            //completedDate = null;

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
            lblTasks_importantSelected.Left = lblTasks_calendar.Right + 20;
            calendar.Visible = false;
        }

        private void lblTasks_calendar_Click(object sender, EventArgs e)
        {
            calendar.Location = new Point(lblTasks_calendar.Left + 70, lblTasks_calendar.Bottom + 180);
            calendar.BringToFront();
            calendar.Visible = true;
        }

        private void lblTasks_important_Click(object sender, EventArgs e)
        {
            lblTasks_important.Visible = false;
            lblTasks_importantSelected.Visible = true;
            isImportant = true;
        }

        private void lblTasks_importantSelected_Click(object sender, EventArgs e)
        {
            lblTasks_important.Visible = true;
            lblTasks_importantSelected.Visible = false;
            isImportant = false;
        }

        private bool checkValidation()
        {
            if (Validation.isEmpty(lblTasks_calendar.Text))
            {
                MessageBox.Show("Please select a date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Validation.isEmpty(txtTasksTask.Text))
            {
                MessageBox.Show("Please set the title of task", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnTasks_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValidation())
                {
                    string dateString = lblTasks_calendar.Text;
                    TaskDTO newTask = new TaskDTO
                    {
                        Title = txtTasksTask.Text,
                        DueDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        IsImportant = isImportant,
                        CreatedDate = DateTime.Now,
                        CreatedBy = user.UserID
                    };
                    bool test = taskBUS.insert(newTask);
                    if (test)
                    {
                        MessageBox.Show("Task added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listTasks = taskBUS.getAllByUserID(user.UserID);
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
            txtTasksTask.Clear();
            lblTasks_calendar.Text = "";
            lblTasks_important.Visible = true;
            lblTasks_importantSelected.Visible = false;
            isImportant = false;
            lblTasks_importantSelected.Location = new Point(67, 51);
            lblTasks_important.Location = new Point(67, 51);
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            if (tableTasks.Columns.Count == 0)
            {
                tableTasks.Columns.Add("clTitle_tasks", "Title");
                tableTasks.Columns.Add("clDuedate_tasks", "Due Date");
                tableTasks.Columns.Add("clImportance_tasks", "Important");
                tableTasks.Columns.Add("clDone_tasks", "Done");
            }

            loadDataTable2("", sortBUS.getAllTask(user.UserID));

        }

        // Hiển thị dữ liệu theo tiêu chi sắp xếp
        public void loadDataTable2(string selectedValue, List<TaskDTO> tasks)
        {
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

        public void loadDataTable(List<TaskDTO> tasks)
        {
            tableTasks.SuspendLayout(); // Tạm dừng cập nhật giao diện
            tableTasks.Rows.Clear();   // Xóa tất cả các hàng cũ

            if (tasks == null || tasks.Count == 0)
            {
                tableTasks.Rows.Clear();
                return;
            }

            tableTasks.Rows.Clear();

            foreach (var task in tasks)
            {
                int rowIndex = tableTasks.Rows.Add();

                tableTasks.Rows[rowIndex].Cells["clTitle_tasks"].Value = task.Title;
                tableTasks.Rows[rowIndex].Cells["clDuedate_tasks"].Value = task.DueDate.ToString("dd/MM/yyyy");
                if (!task.IsImportant)
                {
                    tableTasks.Rows[rowIndex].Cells["clImportance_tasks"].Value = Properties.Resources.Important_24px;
                }
                else
                {
                    tableTasks.Rows[rowIndex].Cells["clImportance_tasks"].Value = Properties.Resources.ImportantSelected_24px;
                }
                if (task.CompletedDate == null)
                {
                    tableTasks.Rows[rowIndex].Cells["clDone_tasks"].Value = Properties.Resources.notDone_24;
                }
                else
                {
                    tableTasks.Rows[rowIndex].Cells["clDone_tasks"].Value = Properties.Resources.done_24;
                }
            }
        }

        private void tableTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex == tableTasks.Columns["clImportance_tasks"].Index)
            {
                try
                {
                    var selectedTask = listTasks[e.RowIndex];
                    var index = listTasks.FindIndex(t => t.TaskID == selectedTask.TaskID);

                    bool previousState = selectedTask.IsImportant;
                    selectedTask.IsImportant = !selectedTask.IsImportant;

                    //Console.WriteLine("selectedTask : " + selectedTask);
                    //Console.WriteLine("previous : " + previousState);
                    //Console.WriteLine("Current : " + selectedTask.IsImportant);

                    bool check = taskBUS.update(selectedTask);

                    if (check)
                    {
                        listTasks[index].IsImportant = !previousState;

                        //tableTasks.Refresh();
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
            else if (e.RowIndex >= 0 && e.ColumnIndex == tableTasks.Columns["clDone_tasks"].Index)
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
                            tableTasks.Rows.RemoveAt(e.RowIndex);
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

        private void tableTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = tableTasks.Columns[e.ColumnIndex].Name;
                object cellValue = tableTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                var selectedTask = listTasks[e.RowIndex];
                int taskid = selectedTask.TaskID;

                TaskInfo taskInfoForm = new TaskInfo(taskid, user);
                taskInfoForm.OnTaskInfoUpdate += TaskInfo_OnTaskInfoUpdate;
                taskInfoForm.ShowDialog();
            }
        }

        public void TaskInfo_OnTaskInfoUpdate(object sender, EventArgs e)
        {
            listTasks = taskBUS.getAllByUserID(user.UserID);
            loadDataTable(listTasks);
        }

        private void CpTooBar1_OnSortByChanged(string sortBy)
        {
            loadDataTable2(sortBy, listTasks);
        }

        private void cpToolBar1_Load(object sender, EventArgs e)
        {
            // Đăng ký sự kiện OnSortByChanged
            cpToolBar1.OnSortByChanged += CpTooBar1_OnSortByChanged;
        }

    }
}
