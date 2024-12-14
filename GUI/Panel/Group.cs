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
using BUS;
using Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using GUI.Components;

namespace GUI.Panel
{
    public partial class Group : Form
    {
        private MonthCalendar calendar;
        private bool isImportant;
        private UserDTO user;
        private List<TaskDTO> listTasks;
        public TaskBUS taskBUS;
        private GroupDTO groupDTO;
        private MenuTaskBar menuTaskBar;
        public Group(UserDTO user, GroupDTO groupDTO, MenuTaskBar menuTaskBar)
        {
            this.user = user;
            this.groupDTO = groupDTO;
            this.menuTaskBar = menuTaskBar;
            InitializeComponent();
            taskBUS = new TaskBUS();
            listTasks = taskBUS.getAllTaskByGroupID(user.UserID,groupDTO.GroupID);
            isImportant = false;
            calendar = new MonthCalendar
            {
                Visible = false,
                MaxSelectionCount = 1
            };
            calendar.DateSelected += Calendar_DateSelected;
            Controls.Add(calendar);
            cpToolBarGroup3.OnExitChangeMember += menuTaskBar.RefreshGroupList;
            
        }

        private void Calendar_DateSelected(object? sender, DateRangeEventArgs e)
        {
            lblGroup_calendar.Text = e.Start.ToString("dd/MM/yyyy");
            lblGroup_important.Left = lblGroup_calendar.Right + 20;
            lblGroup_importantSelected.Left = lblGroup_calendar.Right + 20;
            calendar.Visible = false;
        }

        private void lblGroup_calendar_Click(object sender, EventArgs e)
        {
            calendar.Location = new Point(lblGroup_calendar.Left + 70, lblGroup_calendar.Bottom + 180);
            calendar.BringToFront();
            calendar.Visible = true;
        }

        private void lblGroup_importantSelected_Click(object sender, EventArgs e)
        {
            lblGroup_important.Visible = true;
            lblGroup_importantSelected.Visible = false;
            isImportant = false;
        }

        private void lblGroup_important_Click(object sender, EventArgs e)
        {
            lblGroup_important.Visible = false;
            lblGroup_importantSelected.Visible = true;
            isImportant = true;
        }

        private bool checkValidation()
        {
            if (Validation.isEmpty(lblGroup_calendar.Text))
            {
                MessageBox.Show("Please select a date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Validation.isEmpty(txtGroupTask.Text))
            {
                MessageBox.Show("Please set the title of task", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGroup_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkValidation())
                {
                    string dateString = lblGroup_calendar.Text;
                    TaskDTO newTask = new TaskDTO
                    {
                        Title = txtGroupTask.Text,
                        DueDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        IsImportant = isImportant,
                        CreatedDate = DateTime.Now,
                        CreatedBy = user.UserID,
                        GroupID = groupDTO.GroupID
                    };
                    bool test = taskBUS.insert(newTask);
                    if (test)
                    {
                        MessageBox.Show("Task added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listTasks = taskBUS.getAllTaskByGroupID(user.UserID, groupDTO.GroupID);
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
            txtGroupTask.Clear();
            lblGroup_calendar.Text = "";
            lblGroup_important.Visible = true;
            lblGroup_importantSelected.Visible = false;
            isImportant = false;
            lblGroup_importantSelected.Location = new Point(67, 51);
            lblGroup_important.Location = new Point(67, 51);
        }

        private void loadDataTable(List<TaskDTO> tasks)
        {
            if (tasks == null || tasks.Count == 0)
            {
                return;
            }
            tableGroup.Rows.Clear();

            foreach (var task in tasks)
            {
                int rowIndex = tableGroup.Rows.Add();

                tableGroup.Rows[rowIndex].Cells["clTitle_group"].Value = task.Title;
                tableGroup.Rows[rowIndex].Cells["clDuedate_group"].Value = task.DueDate.ToString("dd/MM/yyyy");
                if (!task.IsImportant)
                {
                    tableGroup.Rows[rowIndex].Cells["clImportance_group"].Value = Properties.Resources.Important_24px;
                }
                else
                {
                    tableGroup.Rows[rowIndex].Cells["clImportance_group"].Value = Properties.Resources.ImportantSelected_24px;
                }
                if (task.CompletedDate == null)
                {
                    tableGroup.Rows[rowIndex].Cells["clDone_group"].Value = Properties.Resources.notDone_24;
                }
                else
                {
                    tableGroup.Rows[rowIndex].Cells["clDone_group"].Value = Properties.Resources.done_24;
                }
            }
        }

        private void Group_Load(object sender, EventArgs e)
        {
            if (tableGroup.Columns.Count == 0)
            {
                tableGroup.Columns.Add("clTitle_group", "Title");
                tableGroup.Columns.Add("clDuedate_group", "Due Date");
                tableGroup.Columns.Add("clImportance_group", "Important");
                tableGroup.Columns.Add("clDone_group", "Done");
            }

            loadDataTable(listTasks);
        }

        private void tableGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tableGroup.Columns["clImportance_group"].Index)
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
            else if (e.RowIndex >= 0 && e.ColumnIndex == tableGroup.Columns["clDone_group"].Index)
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
                            tableGroup.Rows.RemoveAt(e.RowIndex);
                            listTasks.RemoveAt(index);
                        }
                        listTasks = taskBUS.getAllTaskByGroupID(user.UserID, groupDTO.GroupID);
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
