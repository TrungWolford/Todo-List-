using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Panel
{
    public partial class Completed : Form
    {
        private UserDTO user;
        private bool isImportant;
        public TaskBUS taskBUS;
        public List<TaskDTO> listTasks;
        public Completed(UserDTO user)
        {
            this.user = user;
            InitializeComponent();

            taskBUS = new TaskBUS();
            listTasks = taskBUS.getAllTaskCompleted(user.UserID);
            isImportant = false;
        }

        private void Completed_Load(object sender, EventArgs e)
        {
            if (tableCompleted.Columns.Count == 0)
            {
                tableCompleted.Columns.Add("clTitle_cmp", "Title");
                tableCompleted.Columns.Add("clDuedate_cmp", "Due Date");
                tableCompleted.Columns.Add("clImportance_cmp", "Important");
                tableCompleted.Columns.Add("clDone_cmp", "Done");
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
                tableCompleted.Rows.Clear();
                return;
            }

            tableCompleted.Rows.Clear();

            foreach (var task in tasks)
            {
                int rowIndex = tableCompleted.Rows.Add();

                tableCompleted.Rows[rowIndex].Cells["clTitle_cmp"].Value = task.Title;
                tableCompleted.Rows[rowIndex].Cells["clDuedate_cmp"].Value = task.DueDate.ToString("dd/MM/yyyy");
                if (!task.IsImportant)
                {
                    tableCompleted.Rows[rowIndex].Cells["clImportance_cmp"].Value = Properties.Resources.Important_24px;
                }
                else
                {
                    tableCompleted.Rows[rowIndex].Cells["clImportance_cmp"].Value = Properties.Resources.ImportantSelected_24px;
                }
                if (task.CompletedDate == null)
                {
                    tableCompleted.Rows[rowIndex].Cells["clDone_cmp"].Value = Properties.Resources.notDone_24;
                }
                else
                {
                    tableCompleted.Rows[rowIndex].Cells["clDone_cmp"].Value = Properties.Resources.done_24;
                }
            }
        }

        private void tableCompleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tableCompleted.Columns["clDone_cmp"].Index)
            {
                try
                {
                    var selectedTask = listTasks[e.RowIndex];
                    var index = listTasks.FindIndex(t => t.TaskID == selectedTask.TaskID);
                    Console.WriteLine(e.RowIndex);

                    DateTime? previousDate = selectedTask.CompletedDate;

                    selectedTask.CompletedDate = previousDate == null ? DateTime.Now : (DateTime?)null;

                    bool check = taskBUS.update(selectedTask);
                    if (check)
                    {
                        if (selectedTask.CompletedDate == null)
                        {
                            tableCompleted.Rows.RemoveAt(e.RowIndex);
                            listTasks.RemoveAt(index);
                        }
                        listTasks[index].CompletedDate = selectedTask.CompletedDate;
                        listTasks = taskBUS.getAllTaskCompleted(user.UserID);
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

        private void CpToolBar1_OnSortByChanged(string sortBy)
        {
            loadDataTable2(sortBy, listTasks);
        }

        private void cpToolBar1_Load(object sender, EventArgs e)
        {
            // Đăng ký sự kiện OnSortByChanged
            cpToolBar1.OnSortByChanged -= CpToolBar1_OnSortByChanged;
            cpToolBar1.OnSortByChanged += CpToolBar1_OnSortByChanged;
        }
    }
}
