using GUI.Components;
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
using DTO;
using DAO;
using System.Globalization;

namespace GUI.Panel
{
    public partial class TaskInfo : Form
    {
        public event EventHandler OnTaskInfoUpdate;
        private MonthCalendar calendar;
        private List<string> filesToUpload;
        private List<string> taskFiles;
        private List<TaskStep> stepList;

        TaskInfoBUS taskInfoBus;
        AttachmentBUS attachmentBUS;
        StepBUS stepBUS;
        TaskDTO taskDTO;
        UserDTO sessionUser;
        int taskID;

        private bool isSelectedReminder;

        public TaskInfo(int taskID, UserDTO user)
        {
            InitializeComponent();
            sessionUser = user;
            StartPosition = FormStartPosition.CenterScreen;
            this.taskID = taskID;
            Console.WriteLine(taskID);
            isSelectedReminder = false;

            taskInfoBus = new TaskInfoBUS();
            attachmentBUS = new AttachmentBUS();
            stepBUS = new StepBUS();

            // File của task 
            filesToUpload = new List<string>();
            taskFiles = attachmentBUS.GetTaskFiles(taskID);
            // Nếu Task đã có file từ trước thì load
            if (taskFiles.Count > 0)
            {
                LoadAttachmentFiles();
            }

            calendar = new MonthCalendar
            {
                Visible = false,
                MaxSelectionCount = 1
            };
            calendar.DateSelected += Calendar_DateSelected;
            Controls.Add(calendar);

            // Notification
            customeDateTime1.Visible = false;
            customeDateTime1.OnCustomDateTime_Choosed += OnTimePicker_Choosed;

            // Tải thông tin của task
            LoadTaskInfoData();

            // Tải thông tin của step
            LoadStepList();
        }

        private void LoadTaskInfoData()
        {
            taskDTO = taskInfoBus.SelectByTaskID(taskID);
            txt_detailTitle.Text = taskDTO.Title;
            txt_detailDescription.Text = taskDTO.Description;
            lbl_detailDueDate.Text = taskDTO.DueDate.ToString("dd/MM/yyyy");
            lbl_createdDate.Text = taskDTO.CreatedDate.ToString();
            if (taskDTO.CompletedDate != null)
            {
                lbl_doneIcon.Image = Properties.Resources.done_24;
            }
            if (taskDTO.IsImportant)
            {
                lbl_iconImportant.Image = Properties.Resources.ImportantSelected_24px;
            }
            lblTasks_timePicker.Text = taskDTO.ReminderTime?.ToString("dd/MM/yyyy h:mm:ss tt");
        }
        private void LoadAttachmentFiles()
        {
            foreach (string filePath in taskFiles)
            {
                AttachItem item = new AttachItem(Path.GetFileName(filePath), filePath);
                item.OnRemoveFile += Item_OnRemoveFile;
                item.OnDownloadFile += Item_OnDownloadFile;
                AddAttachmentItemToDisplay(item);
            }
        }
        private void Calendar_DateSelected(object? sender, DateRangeEventArgs e)
        {
            lbl_detailDueDate.Text = e.Start.ToString("dd/MM/yyyy");
            calendar.Visible = false;
        }

        private void pnl_detailDueDate_Click(object sender, EventArgs e)
        {
            calendar.Location = new Point(lbl_detailDueDate_icon.Left + 30, lbl_detailDueDate_icon.Bottom + 80);
            calendar.BringToFront();
            calendar.Visible = true;
        }

        private void pnl_detailAddFile_Title_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        if (!filesToUpload.Contains(file))
                        {
                            filesToUpload.Add(file);
                            AttachItem item = new AttachItem(Path.GetFileName(file), file);
                            item.OnRemoveFile += Item_OnRemoveFile;
                            AddAttachmentItemToDisplay(item);
                        }
                    }
                }
            }
        }
        private void AddAttachmentItemToDisplay(AttachItem item)
        {
            pnl_FileItems.Controls.Add(item);
        }
        private void Item_OnRemoveFile(object sender, EventArgs e)
        {
            if (sender is AttachItem item)
            {
                pnl_FileItems.Controls.Remove(item);
                if (!filesToUpload.Remove(item.FileFullPath))
                {
                    taskInfoBus.DeleteFile(item.FileFullPath);
                    attachmentBUS.DeleteFromAttachment(item.FileFullPath, taskID, sessionUser.UserID);
                };
                MessageBox.Show("Delete successfully!");
                item.Dispose();
            }
        }

        private void Item_OnDownloadFile(object sender, EventArgs e)
        {
            if (sender is AttachItem item)
            {
                if (taskFiles.Contains(item.FileFullPath))
                {
                    taskInfoBus.DownloadFile(item.FileFullPath);
                    MessageBox.Show("File save into path: C:/Downloads");
                }
                else
                {
                    MessageBox.Show("You can only download uploaded files");
                }
            }
        }

        private void btn_detailSave_Click(object sender, EventArgs e)
        {
            string newTitle = txt_detailTitle.Text.Trim();
            string newDueDate = lbl_detailDueDate.Text.Trim();
            string newDescription = txt_detailDescription.Text;

            taskDTO.Title = newTitle;
            taskDTO.DueDate = DateTime.ParseExact(newDueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            taskDTO.Description = newDescription;

            List<string> savedFileUrls = new List<string>();

            foreach (string localFilePath in filesToUpload)
            {
                string fileUrl = taskInfoBus.UploadFile(localFilePath, taskID); // Gọi BUS để lưu file
                savedFileUrls.Add(fileUrl); // Lưu URL của file được lưu
            }

            // Cập nhật URL file vào cơ sở dữ liệu
            foreach (string fileUrl in savedFileUrls)
            {
                attachmentBUS.AddToAttachment(fileUrl, taskID, sessionUser.UserID); // Lưu URL vào DB
            }

            // Cập nhật thông tin step vào csdl
            foreach (Control control in pnl_TaskStep.Controls)
            {
                if (control is TaskStep step)
                {
                    // Nếu stepID = 0 ( step mới chưa tồn tại trong db)
                    if (step.stepID == 0)
                    {
                        // Nếu stepName ko rỗng thì mới thêm vào db
                        if (step.stepName != "")
                        {
                            StepDTO newStep = new StepDTO();
                            newStep.StepName = step.stepName;
                            newStep.IsDone = step.isDone;
                            newStep.TaskID = taskID;
                            stepBUS.Insert(newStep);
                        }
                    }
                    else // Nếu step này đã tồn tại trong db thì cập nhật
                    {
                        // Nếu stepName rỗng thì xóa step
                        if (step.stepName == "")
                        {
                            stepBUS.Delete(step.stepID);
                        }
                        else
                        {
                            StepDTO updateStep = stepBUS.SelectByID(step.stepID);
                            updateStep.StepName = step.stepName;
                            updateStep.IsDone = step.isDone;
                            stepBUS.Update(updateStep);
                        }
                    }
                }
            }
            if (isSelectedReminder)
            {
                string dataTimeString = lblTasks_timePicker.Text;
                taskDTO.ReminderTime = DateTime.ParseExact(dataTimeString, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            } else
            {
                taskDTO.ReminderTime = null;
            }
            

            // Cập nhật thông tin của task vào database
            taskInfoBus.UpdateTaskInfo(taskDTO);

            // Gửi sự kiện đến form main để load lại dataTable
            OnTaskInfoUpdate?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Save successfully!");
            this.Close();
        }

        private void btn_detailDelete_Click(object sender, EventArgs e)
        {
            // Xoa cac step
            stepBUS.DeleteTaskStep(taskDTO.TaskID);

            // Xoa cac tep attachment
            taskInfoBus.DeleteTaskFiles(taskDTO.TaskID);

            // xoa task
            taskInfoBus.DeleteTask(taskDTO);

            // Gửi sự kiện đến form main để load lại dataTable
            OnTaskInfoUpdate?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Delete successfully");
            this.Close();
        }
        private void pnl_detailAddFile_MouseEnter(object sender, EventArgs e)
        {
            pnl_detailAddFile_Title.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void pnl_detailAddFile_MouseLeave(object sender, EventArgs e)
        {
            pnl_detailAddFile_Title.BackColor = Color.White;
        }
        private void pnl_detailDuedate_MouseEnter(object sender, EventArgs e)
        {
            pnl_detailDuedate.BackColor = Color.FromArgb(246, 246, 246);
        }

        private void pnl_detailDuedate_MouseLeave(object sender, EventArgs e)
        {
            pnl_detailDuedate.BackColor = Color.White;
        }
        private void lbl_doneIcon_Click(object sender, EventArgs e)
        {
            if (taskDTO.CompletedDate == null)
            {
                taskDTO.CompletedDate = DateTime.Now;
                lbl_doneIcon.Image = Properties.Resources.done_24;
                MessageBox.Show("Marked done");
            }
            else
            {
                taskDTO.CompletedDate = null;
                lbl_doneIcon.Image = Properties.Resources.notDone_24;
                MessageBox.Show("Marked not done");
            }
        }

        private void lbl_iconImportant_Click(object sender, EventArgs e)
        {
            if (taskDTO.IsImportant)
            {
                taskDTO.IsImportant = false;
                lbl_iconImportant.Image = Properties.Resources.Important_24px;
                MessageBox.Show("Marked not important");
            }
            else
            {
                taskDTO.IsImportant = true;
                lbl_iconImportant.Image = Properties.Resources.ImportantSelected_24px;
                MessageBox.Show("Marked important");
            }
        }

        private void btn_AddStep_Click(object sender, EventArgs e)
        {
            TaskStep taskStep = new TaskStep();
            taskStep.OnStepRemove += Step_OnStepRemove;
            pnl_TaskStep.Controls.Add(taskStep);
        }
        private void LoadStepList()
        {
            List<StepDTO> stepDTOs = stepBUS.StepListByTaskID(taskID);
            foreach (StepDTO stepDTO in stepDTOs)
            {
                TaskStep taskStep = new TaskStep(stepDTO.StepID, stepDTO.StepName, stepDTO.IsDone);
                taskStep.OnStepRemove += Step_OnStepRemove;
                pnl_TaskStep.Controls.Add(taskStep);
            }
        }
        private void Step_OnStepRemove(object sender, EventArgs e)
        {
            if (sender is TaskStep step)
            {
                if (step.stepID != 0)
                {
                    stepBUS.Delete(step.stepID);
                }

                pnl_FileItems.Controls.Remove(step);
                MessageBox.Show("Delete successfully");
                step.Dispose();
            }
        }

        private void lblTasks_timePicker_Click(object sender, EventArgs e)
        {
            customeDateTime1.Visible = true;
            //lblTasks_timePicker.Text = customeDateTime
        }
        private void OnTimePicker_Choosed(object sender, DateTime dateTime)
        {
            if (sender is CustomeDateTime)
            {
                lblTasks_timePicker.Text = dateTime.ToString("dd/MM/yyyy h:mm:ss tt");
                isSelectedReminder = true;
            }
        }
    }
}
