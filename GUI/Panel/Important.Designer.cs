namespace GUI.Panel
{
    partial class Important
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cpToolBar = new Components.cpToolBar();
            pnlContentImp_center = new System.Windows.Forms.Panel();
            lblImp_timePicker = new Label();
            btnImp_add = new Button();
            lblImp_calendar = new Label();
            txtImportantTask = new TextBox();
            pnlContentImp_bottom = new System.Windows.Forms.Panel();
            tableImportant = new DataGridView();
            clTitle_imp = new DataGridViewTextBoxColumn();
            clDuedate_imp = new DataGridViewTextBoxColumn();
            clImportance_imp = new DataGridViewImageColumn();
            clDone_imp = new DataGridViewImageColumn();
            customeDateTime1 = new Components.CustomeDateTime();
            toolTip_impCalendar = new ToolTip(components);
            toolTip_impImportant = new ToolTip(components);
            toolTip_impImportantSelected = new ToolTip(components);
            chatBot1 = new Components.chatBot();
            pnlContentImp_center.SuspendLayout();
            pnlContentImp_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableImportant).BeginInit();
            SuspendLayout();
            // 
            // cpToolBar
            // 
            cpToolBar.Anchor = AnchorStyles.Top;
            cpToolBar.BackColor = SystemColors.ControlDark;
            cpToolBar.Location = new Point(71, 31);
            cpToolBar.Name = "cpToolBar";
            cpToolBar.Size = new Size(1040, 108);
            cpToolBar.TabIndex = 0;
            cpToolBar.OnSortByChanged += CpToolBar_OnSortByChanged;
            cpToolBar.Load += cpToolBar_Load;
            // 
            // pnlContentImp_center
            // 
            pnlContentImp_center.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContentImp_center.BackColor = Color.White;
            pnlContentImp_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContentImp_center.Controls.Add(lblImp_timePicker);
            pnlContentImp_center.Controls.Add(btnImp_add);
            pnlContentImp_center.Controls.Add(lblImp_calendar);
            pnlContentImp_center.Controls.Add(txtImportantTask);
            pnlContentImp_center.Location = new Point(71, 167);
            pnlContentImp_center.Name = "pnlContentImp_center";
            pnlContentImp_center.Size = new Size(1039, 108);
            pnlContentImp_center.TabIndex = 2;
            // 
            // lblImp_timePicker
            // 
            lblImp_timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblImp_timePicker.Cursor = Cursors.Hand;
            lblImp_timePicker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImp_timePicker.Image = Properties.Resources.notification_32px;
            lblImp_timePicker.ImageAlign = ContentAlignment.MiddleLeft;
            lblImp_timePicker.Location = new Point(133, 53);
            lblImp_timePicker.Name = "lblImp_timePicker";
            lblImp_timePicker.Padding = new Padding(3, 0, 3, 0);
            lblImp_timePicker.Size = new Size(307, 44);
            lblImp_timePicker.TabIndex = 8;
            lblImp_timePicker.TextAlign = ContentAlignment.MiddleCenter;
            lblImp_timePicker.Click += lblImp_timePicker_Click;
            // 
            // btnImp_add
            // 
            btnImp_add.Anchor = AnchorStyles.Right;
            btnImp_add.Location = new Point(927, 51);
            btnImp_add.Name = "btnImp_add";
            btnImp_add.Size = new Size(94, 44);
            btnImp_add.TabIndex = 3;
            btnImp_add.Text = "Add";
            btnImp_add.UseVisualStyleBackColor = true;
            btnImp_add.Click += btnImp_add_Click;
            // 
            // lblImp_calendar
            // 
            lblImp_calendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblImp_calendar.Cursor = Cursors.Hand;
            lblImp_calendar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImp_calendar.Image = Properties.Resources.calendar;
            lblImp_calendar.ImageAlign = ContentAlignment.MiddleLeft;
            lblImp_calendar.Location = new Point(15, 51);
            lblImp_calendar.Name = "lblImp_calendar";
            lblImp_calendar.Size = new Size(170, 44);
            lblImp_calendar.TabIndex = 1;
            lblImp_calendar.TextAlign = ContentAlignment.MiddleRight;
            toolTip_impCalendar.SetToolTip(lblImp_calendar, "Add Due Date");
            lblImp_calendar.Click += lblImp_calendar_Click;
            // 
            // txtImportantTask
            // 
            txtImportantTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImportantTask.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportantTask.Location = new Point(-2, -3);
            txtImportantTask.Name = "txtImportantTask";
            txtImportantTask.PlaceholderText = "New task";
            txtImportantTask.Size = new Size(1035, 38);
            txtImportantTask.TabIndex = 0;
            // 
            // pnlContentImp_bottom
            // 
            pnlContentImp_bottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContentImp_bottom.Controls.Add(tableImportant);
            pnlContentImp_bottom.Location = new Point(71, 297);
            pnlContentImp_bottom.Name = "pnlContentImp_bottom";
            pnlContentImp_bottom.Size = new Size(1040, 525);
            pnlContentImp_bottom.TabIndex = 3;
            // 
            // tableImportant
            // 
            tableImportant.AllowUserToAddRows = false;
            tableImportant.AllowUserToDeleteRows = false;
            tableImportant.AllowUserToResizeColumns = false;
            tableImportant.AllowUserToResizeRows = false;
            tableImportant.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableImportant.BackgroundColor = Color.White;
            tableImportant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportant.Columns.AddRange(new DataGridViewColumn[] { clTitle_imp, clDuedate_imp, clImportance_imp, clDone_imp });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableImportant.DefaultCellStyle = dataGridViewCellStyle1;
            tableImportant.Location = new Point(3, 3);
            tableImportant.Name = "tableImportant";
            tableImportant.RowHeadersWidth = 51;
            tableImportant.Size = new Size(1037, 522);
            tableImportant.TabIndex = 1;
            tableImportant.CellContentClick += tableImportant_CellContentClick;
            tableImportant.CellDoubleClick += tableImportant_CellDoubleClick;
            // 
            // clTitle_imp
            // 
            clTitle_imp.FillWeight = 518.743652F;
            clTitle_imp.HeaderText = "Title";
            clTitle_imp.MinimumWidth = 6;
            clTitle_imp.Name = "clTitle_imp";
            clTitle_imp.ReadOnly = true;
            clTitle_imp.Width = 640;
            // 
            // clDuedate_imp
            // 
            clDuedate_imp.FillWeight = 127.232323F;
            clDuedate_imp.HeaderText = "Due date";
            clDuedate_imp.MinimumWidth = 6;
            clDuedate_imp.Name = "clDuedate_imp";
            clDuedate_imp.ReadOnly = true;
            clDuedate_imp.Width = 157;
            // 
            // clImportance_imp
            // 
            clImportance_imp.FillWeight = 96.04276F;
            clImportance_imp.HeaderText = "Importance";
            clImportance_imp.Image = Properties.Resources.Important_24px;
            clImportance_imp.MinimumWidth = 6;
            clImportance_imp.Name = "clImportance_imp";
            clImportance_imp.ReadOnly = true;
            clImportance_imp.Resizable = DataGridViewTriState.True;
            clImportance_imp.SortMode = DataGridViewColumnSortMode.Automatic;
            clImportance_imp.Width = 118;
            // 
            // clDone_imp
            // 
            clDone_imp.FillWeight = 57.9811935F;
            clDone_imp.HeaderText = "Done";
            clDone_imp.Image = Properties.Resources.notDone_24;
            clDone_imp.MinimumWidth = 6;
            clDone_imp.Name = "clDone_imp";
            clDone_imp.ReadOnly = true;
            clDone_imp.Resizable = DataGridViewTriState.True;
            clDone_imp.SortMode = DataGridViewColumnSortMode.Automatic;
            clDone_imp.Width = 72;
            // 
            // customeDateTime1
            // 
            customeDateTime1.Location = new Point(215, 267);
            customeDateTime1.Name = "customeDateTime1";
            customeDateTime1.Size = new Size(261, 353);
            customeDateTime1.TabIndex = 4;
            customeDateTime1.Visible = false;
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
            // Important
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(chatBot1);
            Controls.Add(customeDateTime1);
            Controls.Add(pnlContentImp_bottom);
            Controls.Add(pnlContentImp_center);
            Controls.Add(cpToolBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Important";
            Text = "Important";
            Load += Important_Load;
            pnlContentImp_center.ResumeLayout(false);
            pnlContentImp_center.PerformLayout();
            pnlContentImp_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableImportant).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.cpToolBar cpToolBar;
        private System.Windows.Forms.Panel pnlContentImp_center;
        private Button btnImp_add;
        private Label lblImp_calendar;
        private TextBox txtImportantTask;
        private System.Windows.Forms.Panel pnlContentImp_bottom;
        private DataGridView tableImportant;
        private ToolTip toolTip_impCalendar;
        private ToolTip toolTip_impImportant;
        private ToolTip toolTip_impImportantSelected;
        private DataGridViewTextBoxColumn clTitle_imp;
        private DataGridViewTextBoxColumn clDuedate_imp;
        private DataGridViewImageColumn clImportance_imp;
        private DataGridViewImageColumn clDone_imp;
        private Components.CustomeDateTime customeDateTime1;
        private Label lblImp_timePicker;
        private Components.chatBot chatBot1;
    }
}