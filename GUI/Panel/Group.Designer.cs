namespace GUI.Panel
{
    partial class Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlContentGroup_center = new System.Windows.Forms.Panel();
            lblGroup_timePicker = new Label();
            lblGroup_importantSelected = new Label();
            btnGroup_add = new Button();
            lblGroup_important = new Label();
            lblGroup_calendar = new Label();
            txtGroupTask = new TextBox();
            pnlContentGroup_bottom = new System.Windows.Forms.Panel();
            customeDateTime1 = new Components.CustomeDateTime();
            tableGroup = new DataGridView();
            clTitle_group = new DataGridViewTextBoxColumn();
            clDuedate_group = new DataGridViewTextBoxColumn();
            clImportance_group = new DataGridViewImageColumn();
            clDone_group = new DataGridViewImageColumn();
            chatBot1 = new Components.chatBot();
            pnlContentGroup_center.SuspendLayout();
            pnlContentGroup_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableGroup).BeginInit();
            SuspendLayout();
            // 
            // pnlContentGroup_center
            // 
            pnlContentGroup_center.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContentGroup_center.BackColor = Color.White;
            pnlContentGroup_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContentGroup_center.Controls.Add(lblGroup_timePicker);
            pnlContentGroup_center.Controls.Add(lblGroup_importantSelected);
            pnlContentGroup_center.Controls.Add(btnGroup_add);
            pnlContentGroup_center.Controls.Add(lblGroup_important);
            pnlContentGroup_center.Controls.Add(lblGroup_calendar);
            pnlContentGroup_center.Controls.Add(txtGroupTask);
            pnlContentGroup_center.Location = new Point(71, 167);
            pnlContentGroup_center.Name = "pnlContentGroup_center";
            pnlContentGroup_center.Size = new Size(1039, 108);
            pnlContentGroup_center.TabIndex = 3;
            // 
            // lblGroup_timePicker
            // 
            lblGroup_timePicker.Anchor = AnchorStyles.Left;
            lblGroup_timePicker.Cursor = Cursors.Hand;
            lblGroup_timePicker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGroup_timePicker.Image = Properties.Resources.notification_32px;
            lblGroup_timePicker.ImageAlign = ContentAlignment.MiddleLeft;
            lblGroup_timePicker.Location = new Point(147, 43);
            lblGroup_timePicker.Name = "lblGroup_timePicker";
            lblGroup_timePicker.Padding = new Padding(3, 0, 3, 0);
            lblGroup_timePicker.Size = new Size(351, 56);
            lblGroup_timePicker.TabIndex = 8;
            lblGroup_timePicker.TextAlign = ContentAlignment.MiddleCenter;
            lblGroup_timePicker.Click += lblTasks_timePicker_Click;
            // 
            // lblGroup_importantSelected
            // 
            lblGroup_importantSelected.Anchor = AnchorStyles.Left;
            lblGroup_importantSelected.Cursor = Cursors.Hand;
            lblGroup_importantSelected.Image = (Image)resources.GetObject("lblGroup_importantSelected.Image");
            lblGroup_importantSelected.Location = new Point(67, 55);
            lblGroup_importantSelected.Name = "lblGroup_importantSelected";
            lblGroup_importantSelected.Size = new Size(57, 44);
            lblGroup_importantSelected.TabIndex = 6;
            lblGroup_importantSelected.Visible = false;
            lblGroup_importantSelected.Click += lblGroup_importantSelected_Click;
            // 
            // btnGroup_add
            // 
            btnGroup_add.Anchor = AnchorStyles.Right;
            btnGroup_add.Location = new Point(927, 51);
            btnGroup_add.Name = "btnGroup_add";
            btnGroup_add.Size = new Size(94, 44);
            btnGroup_add.TabIndex = 3;
            btnGroup_add.Text = "Add";
            btnGroup_add.UseVisualStyleBackColor = true;
            btnGroup_add.Click += btnGroup_add_Click;
            // 
            // lblGroup_important
            // 
            lblGroup_important.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblGroup_important.Cursor = Cursors.Hand;
            lblGroup_important.Image = (Image)resources.GetObject("lblGroup_important.Image");
            lblGroup_important.Location = new Point(67, 55);
            lblGroup_important.Name = "lblGroup_important";
            lblGroup_important.Size = new Size(57, 44);
            lblGroup_important.TabIndex = 2;
            lblGroup_important.Click += lblGroup_important_Click;
            // 
            // lblGroup_calendar
            // 
            lblGroup_calendar.Anchor = AnchorStyles.Left;
            lblGroup_calendar.Cursor = Cursors.Hand;
            lblGroup_calendar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGroup_calendar.Image = Properties.Resources.calendar;
            lblGroup_calendar.ImageAlign = ContentAlignment.MiddleLeft;
            lblGroup_calendar.Location = new Point(15, 55);
            lblGroup_calendar.Name = "lblGroup_calendar";
            lblGroup_calendar.Size = new Size(170, 44);
            lblGroup_calendar.TabIndex = 1;
            lblGroup_calendar.TextAlign = ContentAlignment.MiddleRight;
            lblGroup_calendar.Click += lblGroup_calendar_Click;
            // 
            // txtGroupTask
            // 
            txtGroupTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGroupTask.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGroupTask.Location = new Point(-2, -3);
            txtGroupTask.Name = "txtGroupTask";
            txtGroupTask.PlaceholderText = "New task";
            txtGroupTask.Size = new Size(1035, 38);
            txtGroupTask.TabIndex = 0;
            txtGroupTask.TextChanged += txtGroupTask_TextChanged;
            // 
            // pnlContentGroup_bottom
            // 
            pnlContentGroup_bottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContentGroup_bottom.Controls.Add(customeDateTime1);
            pnlContentGroup_bottom.Controls.Add(tableGroup);
            pnlContentGroup_bottom.Location = new Point(71, 303);
            pnlContentGroup_bottom.Name = "pnlContentGroup_bottom";
            pnlContentGroup_bottom.Size = new Size(1040, 525);
            pnlContentGroup_bottom.TabIndex = 4;
            // 
            // customeDateTime1
            // 
            customeDateTime1.Location = new Point(161, -40);
            customeDateTime1.Name = "customeDateTime1";
            customeDateTime1.Size = new Size(294, 493);
            customeDateTime1.TabIndex = 5;
            customeDateTime1.Visible = false;
            // 
            // tableGroup
            // 
            tableGroup.AllowUserToAddRows = false;
            tableGroup.AllowUserToDeleteRows = false;
            tableGroup.AllowUserToResizeColumns = false;
            tableGroup.AllowUserToResizeRows = false;
            tableGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableGroup.BackgroundColor = Color.White;
            tableGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGroup.Columns.AddRange(new DataGridViewColumn[] { clTitle_group, clDuedate_group, clImportance_group, clDone_group });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableGroup.DefaultCellStyle = dataGridViewCellStyle1;
            tableGroup.Location = new Point(0, 3);
            tableGroup.Name = "tableGroup";
            tableGroup.RowHeadersWidth = 51;
            tableGroup.Size = new Size(1035, 522);
            tableGroup.TabIndex = 1;
            tableGroup.CellContentClick += tableGroup_CellContentClick;
            tableGroup.CellDoubleClick += tableGroup_CellDoubleClick;
            // 
            // clTitle_group
            // 
            clTitle_group.FillWeight = 518.743652F;
            clTitle_group.HeaderText = "Title";
            clTitle_group.MinimumWidth = 6;
            clTitle_group.Name = "clTitle_group";
            clTitle_group.ReadOnly = true;
            clTitle_group.Width = 640;
            // 
            // clDuedate_group
            // 
            clDuedate_group.FillWeight = 127.232323F;
            clDuedate_group.HeaderText = "Due date";
            clDuedate_group.MinimumWidth = 6;
            clDuedate_group.Name = "clDuedate_group";
            clDuedate_group.ReadOnly = true;
            clDuedate_group.Width = 157;
            // 
            // clImportance_group
            // 
            clImportance_group.FillWeight = 96.04276F;
            clImportance_group.HeaderText = "Importance";
            clImportance_group.Image = Properties.Resources.Important_24px;
            clImportance_group.MinimumWidth = 6;
            clImportance_group.Name = "clImportance_group";
            clImportance_group.ReadOnly = true;
            clImportance_group.Resizable = DataGridViewTriState.True;
            clImportance_group.SortMode = DataGridViewColumnSortMode.Automatic;
            clImportance_group.Width = 118;
            // 
            // clDone_group
            // 
            clDone_group.FillWeight = 57.9811935F;
            clDone_group.HeaderText = "Done";
            clDone_group.Image = Properties.Resources.notDone_24;
            clDone_group.MinimumWidth = 6;
            clDone_group.Name = "clDone_group";
            clDone_group.ReadOnly = true;
            clDone_group.Resizable = DataGridViewTriState.True;
            clDone_group.SortMode = DataGridViewColumnSortMode.Automatic;
            clDone_group.Width = 72;
            // 
            // chatBot1
            // 
            chatBot1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chatBot1.Cursor = Cursors.Hand;
            chatBot1.Location = new Point(1117, 773);
            chatBot1.Name = "chatBot1";
            chatBot1.Size = new Size(50, 68);
            chatBot1.TabIndex = 6;
            // 
            // Group
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(chatBot1);
            Controls.Add(pnlContentGroup_bottom);
            Controls.Add(pnlContentGroup_center);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Group";
            Text = "Group";
            Load += Group_Load;
            pnlContentGroup_center.ResumeLayout(false);
            pnlContentGroup_center.PerformLayout();
            pnlContentGroup_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableGroup).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlContentGroup_center;
        private Label lblGroup_importantSelected;
        private Button btnGroup_add;
        private Label lblGroup_important;
        private Label lblGroup_calendar;
        private TextBox txtGroupTask;
        private System.Windows.Forms.Panel pnlContentGroup_bottom;
        private DataGridView tableGroup;
        private DataGridViewTextBoxColumn clTitle_group;
        private DataGridViewTextBoxColumn clDuedate_group;
        private DataGridViewImageColumn clImportance_group;
        private DataGridViewImageColumn clDone_group;
        private Components.cpToolBarGroup cpToolBarGroup1;
        private Components.cpToolBarGroup cpToolBarGroup2;
        private Components.cpToolBarGroup cpToolBarGroup3;
        private Components.CustomeDateTime customeDateTime1;
        private Label lblGroup_timePicker;
        private Components.chatBot chatBot1;
    }
}