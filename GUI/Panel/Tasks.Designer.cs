namespace GUI.Panel
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cpToolBar1 = new Components.cpToolBar();
            pnlContentTasks_center = new System.Windows.Forms.Panel();
            lblTasks_timePicker = new Label();
            lblTasks_importantSelected = new Label();
            btnTasks_add = new Button();
            lblTasks_important = new Label();
            lblTasks_calendar = new Label();
            txtTasksTask = new TextBox();
            pnlContentTasks_bottom = new System.Windows.Forms.Panel();
            tableTasks = new DataGridView();
            clTitle_tasks = new DataGridViewTextBoxColumn();
            clDuedate_tasks = new DataGridViewTextBoxColumn();
            clImportance_tasks = new DataGridViewImageColumn();
            clDone_tasks = new DataGridViewImageColumn();
            toolTip_tasksCalendar = new ToolTip(components);
            toolTip_tasksImportant = new ToolTip(components);
            toolTip_tasksImportantSelected = new ToolTip(components);
            toolTip_tasksRemindMe = new ToolTip(components);
            pnlContentTasks_center.SuspendLayout();
            pnlContentTasks_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableTasks).BeginInit();
            SuspendLayout();
            // 
            // cpToolBar1
            // 
            cpToolBar1.BackColor = Color.Transparent;
            cpToolBar1.Location = new Point(71, 31);
            cpToolBar1.Name = "cpToolBar1";
            cpToolBar1.Size = new Size(1040, 108);
            cpToolBar1.TabIndex = 0;
            cpToolBar1.Load += cpToolBar1_Load;
            // 
            // pnlContentTasks_center
            // 
            pnlContentTasks_center.BackColor = Color.White;
            pnlContentTasks_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContentTasks_center.Controls.Add(lblTasks_timePicker);
            pnlContentTasks_center.Controls.Add(lblTasks_importantSelected);
            pnlContentTasks_center.Controls.Add(btnTasks_add);
            pnlContentTasks_center.Controls.Add(lblTasks_important);
            pnlContentTasks_center.Controls.Add(lblTasks_calendar);
            pnlContentTasks_center.Controls.Add(txtTasksTask);
            pnlContentTasks_center.Location = new Point(71, 167);
            pnlContentTasks_center.Name = "pnlContentTasks_center";
            pnlContentTasks_center.Size = new Size(1039, 108);
            pnlContentTasks_center.TabIndex = 2;
            // 
            // lblTasks_timePicker
            // 
            lblTasks_timePicker.Cursor = Cursors.Hand;
            lblTasks_timePicker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTasks_timePicker.Image = Properties.Resources.notification_32px;
            lblTasks_timePicker.ImageAlign = ContentAlignment.MiddleLeft;
            lblTasks_timePicker.Location = new Point(139, 51);
            lblTasks_timePicker.Name = "lblTasks_timePicker";
            lblTasks_timePicker.Padding = new Padding(3, 0, 3, 0);
            lblTasks_timePicker.Size = new Size(214, 44);
            lblTasks_timePicker.TabIndex = 7;
            lblTasks_timePicker.TextAlign = ContentAlignment.MiddleCenter;
            toolTip_tasksRemindMe.SetToolTip(lblTasks_timePicker, "Remind Me");
            // 
            // lblTasks_importantSelected
            // 
            lblTasks_importantSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTasks_importantSelected.Cursor = Cursors.Hand;
            lblTasks_importantSelected.Image = (Image)resources.GetObject("lblTasks_importantSelected.Image");
            lblTasks_importantSelected.Location = new Point(67, 51);
            lblTasks_importantSelected.Name = "lblTasks_importantSelected";
            lblTasks_importantSelected.Size = new Size(57, 44);
            lblTasks_importantSelected.TabIndex = 6;
            toolTip_tasksImportantSelected.SetToolTip(lblTasks_importantSelected, "Remove importance level");
            lblTasks_importantSelected.Visible = false;
            lblTasks_importantSelected.Click += lblTasks_importantSelected_Click;
            // 
            // btnTasks_add
            // 
            btnTasks_add.Location = new Point(927, 51);
            btnTasks_add.Name = "btnTasks_add";
            btnTasks_add.Size = new Size(94, 44);
            btnTasks_add.TabIndex = 3;
            btnTasks_add.Text = "Add";
            btnTasks_add.UseVisualStyleBackColor = true;
            btnTasks_add.Click += btnTasks_add_Click;
            // 
            // lblTasks_important
            // 
            lblTasks_important.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTasks_important.Cursor = Cursors.Hand;
            lblTasks_important.Image = (Image)resources.GetObject("lblTasks_important.Image");
            lblTasks_important.Location = new Point(67, 51);
            lblTasks_important.Name = "lblTasks_important";
            lblTasks_important.Size = new Size(57, 44);
            lblTasks_important.TabIndex = 2;
            toolTip_tasksImportant.SetToolTip(lblTasks_important, "Mark the task as important");
            lblTasks_important.Click += lblTasks_important_Click;
            // 
            // lblTasks_calendar
            // 
            lblTasks_calendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTasks_calendar.Cursor = Cursors.Hand;
            lblTasks_calendar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTasks_calendar.Image = Properties.Resources.calendar;
            lblTasks_calendar.ImageAlign = ContentAlignment.MiddleLeft;
            lblTasks_calendar.Location = new Point(15, 51);
            lblTasks_calendar.Name = "lblTasks_calendar";
            lblTasks_calendar.Size = new Size(170, 44);
            lblTasks_calendar.TabIndex = 1;
            lblTasks_calendar.TextAlign = ContentAlignment.MiddleRight;
            toolTip_tasksCalendar.SetToolTip(lblTasks_calendar, "Add Due Date");
            lblTasks_calendar.Click += lblTasks_calendar_Click;
            // 
            // txtTasksTask
            // 
            txtTasksTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTasksTask.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTasksTask.Location = new Point(-2, -3);
            txtTasksTask.Name = "txtTasksTask";
            txtTasksTask.PlaceholderText = "New task";
            txtTasksTask.Size = new Size(1035, 38);
            txtTasksTask.TabIndex = 0;
            // 
            // pnlContentTasks_bottom
            // 
            pnlContentTasks_bottom.Controls.Add(tableTasks);
            pnlContentTasks_bottom.Location = new Point(71, 297);
            pnlContentTasks_bottom.Name = "pnlContentTasks_bottom";
            pnlContentTasks_bottom.Size = new Size(1040, 525);
            pnlContentTasks_bottom.TabIndex = 3;
            // 
            // tableTasks
            // 
            tableTasks.AllowUserToAddRows = false;
            tableTasks.AllowUserToDeleteRows = false;
            tableTasks.AllowUserToResizeColumns = false;
            tableTasks.AllowUserToResizeRows = false;
            tableTasks.BackgroundColor = Color.White;
            tableTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableTasks.Columns.AddRange(new DataGridViewColumn[] { clTitle_tasks, clDuedate_tasks, clImportance_tasks, clDone_tasks });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableTasks.DefaultCellStyle = dataGridViewCellStyle1;
            tableTasks.Dock = DockStyle.Fill;
            tableTasks.Location = new Point(0, 0);
            tableTasks.Name = "tableTasks";
            tableTasks.RowHeadersWidth = 51;
            tableTasks.Size = new Size(1040, 525);
            tableTasks.TabIndex = 2;
            tableTasks.CellClick += tableTasks_CellContentClick;
            tableTasks.CellContentClick += tableTasks_CellContentClick;
            tableTasks.CellDoubleClick += tableTasks_CellDoubleClick;
            // 
            // clTitle_tasks
            // 
            clTitle_tasks.FillWeight = 518.743652F;
            clTitle_tasks.HeaderText = "Title";
            clTitle_tasks.MinimumWidth = 6;
            clTitle_tasks.Name = "clTitle_tasks";
            clTitle_tasks.ReadOnly = true;
            clTitle_tasks.Width = 630;
            // 
            // clDuedate_tasks
            // 
            clDuedate_tasks.FillWeight = 127.232323F;
            clDuedate_tasks.HeaderText = "Due date";
            clDuedate_tasks.MinimumWidth = 6;
            clDuedate_tasks.Name = "clDuedate_tasks";
            clDuedate_tasks.ReadOnly = true;
            clDuedate_tasks.Width = 157;
            // 
            // clImportance_tasks
            // 
            clImportance_tasks.FillWeight = 96.04276F;
            clImportance_tasks.HeaderText = "Importance";
            clImportance_tasks.Image = Properties.Resources.sort2;
            clImportance_tasks.MinimumWidth = 6;
            clImportance_tasks.Name = "clImportance_tasks";
            clImportance_tasks.ReadOnly = true;
            clImportance_tasks.Resizable = DataGridViewTriState.True;
            clImportance_tasks.SortMode = DataGridViewColumnSortMode.Automatic;
            clImportance_tasks.Width = 118;
            // 
            // clDone_tasks
            // 
            clDone_tasks.FillWeight = 57.9811935F;
            clDone_tasks.HeaderText = "Done";
            clDone_tasks.Image = Properties.Resources.notDone_24;
            clDone_tasks.MinimumWidth = 6;
            clDone_tasks.Name = "clDone_tasks";
            clDone_tasks.ReadOnly = true;
            clDone_tasks.Resizable = DataGridViewTriState.True;
            clDone_tasks.SortMode = DataGridViewColumnSortMode.Automatic;
            clDone_tasks.Width = 82;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(pnlContentTasks_bottom);
            Controls.Add(pnlContentTasks_center);
            Controls.Add(cpToolBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tasks";
            Text = "Tasks";
            Load += Tasks_Load;
            pnlContentTasks_center.ResumeLayout(false);
            pnlContentTasks_center.PerformLayout();
            pnlContentTasks_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.cpToolBar cpToolBar1;
        private System.Windows.Forms.Panel pnlContentTasks_center;
        private Button btnTasks_add;
        private Label lblTasks_important;
        private Label lblTasks_calendar;
        private TextBox txtTasksTask;
        private System.Windows.Forms.Panel pnlContentTasks_bottom;
        private DataGridView tableTasks;
        private Label lblTasks_importantSelected;
        private ToolTip toolTip_tasksImportantSelected;
        private ToolTip toolTip_tasksCalendar;
        private ToolTip toolTip_tasksImportant;
        private DataGridViewTextBoxColumn clTitle_tasks;
        private DataGridViewTextBoxColumn clDuedate_tasks;
        private DataGridViewImageColumn clImportance_tasks;
        private DataGridViewImageColumn clDone_tasks;
        private Label lblTasks_timePicker;
        private ToolTip toolTip_tasksRemindMe;
    }
}