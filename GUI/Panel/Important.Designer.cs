﻿namespace GUI.Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Important));
            cpToolBar = new Components.cpToolBar(this);
            pnlContentImp_center = new System.Windows.Forms.Panel();
            lblImp_importantSelected = new Label();
            btnImp_add = new Button();
            lblImp_important = new Label();
            lblImp_calendar = new Label();
            txtImportantTask = new TextBox();
            pnlContentImp_bottom = new System.Windows.Forms.Panel();
            tableImportant = new DataGridView();
            clTitle_imp = new DataGridViewTextBoxColumn();
            clDuedate_imp = new DataGridViewTextBoxColumn();
            clImportance_imp = new DataGridViewTextBoxColumn();
            clDone_imp = new DataGridViewTextBoxColumn();
            toolTip_impCalendar = new ToolTip(components);
            toolTip_impImportant = new ToolTip(components);
            toolTip_impImportantSelected = new ToolTip(components);
            pnlContentImp_center.SuspendLayout();
            pnlContentImp_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableImportant).BeginInit();
            SuspendLayout();
            // 
            // cpToolBar
            // 
            cpToolBar.BackColor = SystemColors.ControlDark;
            cpToolBar.Location = new Point(71, 31);
            cpToolBar.Name = "cpToolBar";
            cpToolBar.Size = new Size(1040, 108);
            cpToolBar.TabIndex = 0;
            // 
            // pnlContentImp_center
            // 
            pnlContentImp_center.BackColor = Color.White;
            pnlContentImp_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContentImp_center.Controls.Add(lblImp_importantSelected);
            pnlContentImp_center.Controls.Add(btnImp_add);
            pnlContentImp_center.Controls.Add(lblImp_important);
            pnlContentImp_center.Controls.Add(lblImp_calendar);
            pnlContentImp_center.Controls.Add(txtImportantTask);
            pnlContentImp_center.Location = new Point(71, 167);
            pnlContentImp_center.Name = "pnlContentImp_center";
            pnlContentImp_center.Size = new Size(1040, 108);
            pnlContentImp_center.TabIndex = 2;
            // 
            // lblImp_importantSelected
            // 
            lblImp_importantSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImp_importantSelected.Cursor = Cursors.Hand;
            lblImp_importantSelected.Image = (Image)resources.GetObject("lblImp_importantSelected.Image");
            lblImp_importantSelected.Location = new Point(67, 51);
            lblImp_importantSelected.Name = "lblImp_importantSelected";
            lblImp_importantSelected.Size = new Size(57, 44);
            lblImp_importantSelected.TabIndex = 5;
            toolTip_impImportantSelected.SetToolTip(lblImp_importantSelected, "Remove importance level");
            lblImp_importantSelected.Visible = false;
            lblImp_importantSelected.Click += lblImp_importantSelected_Click;
            // 
            // btnImp_add
            // 
            btnImp_add.Location = new Point(927, 51);
            btnImp_add.Name = "btnImp_add";
            btnImp_add.Size = new Size(94, 44);
            btnImp_add.TabIndex = 3;
            btnImp_add.Text = "Add";
            btnImp_add.UseVisualStyleBackColor = true;
            // 
            // lblImp_important
            // 
            lblImp_important.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImp_important.Cursor = Cursors.Hand;
            lblImp_important.Image = (Image)resources.GetObject("lblImp_important.Image");
            lblImp_important.Location = new Point(67, 51);
            lblImp_important.Name = "lblImp_important";
            lblImp_important.Size = new Size(57, 44);
            lblImp_important.TabIndex = 2;
            toolTip_impImportant.SetToolTip(lblImp_important, "Mark the task as important");
            lblImp_important.Click += lblImp_important_Click;
            // 
            // lblImp_calendar
            // 
            lblImp_calendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            txtImportantTask.Location = new Point(-2, -2);
            txtImportantTask.Name = "txtImportantTask";
            txtImportantTask.PlaceholderText = "New task";
            txtImportantTask.Size = new Size(1035, 38);
            txtImportantTask.TabIndex = 0;
            // 
            // pnlContentImp_bottom
            // 
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
            tableImportant.BackgroundColor = Color.White;
            tableImportant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportant.Columns.AddRange(new DataGridViewColumn[] { clTitle_imp, clDuedate_imp, clImportance_imp, clDone_imp });
            tableImportant.Dock = DockStyle.Fill;
            tableImportant.Location = new Point(0, 0);
            tableImportant.Name = "tableImportant";
            tableImportant.RowHeadersWidth = 51;
            tableImportant.Size = new Size(1040, 525);
            tableImportant.TabIndex = 1;
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
            clImportance_imp.MinimumWidth = 6;
            clImportance_imp.Name = "clImportance_imp";
            clImportance_imp.ReadOnly = true;
            clImportance_imp.Width = 118;
            // 
            // clDone_imp
            // 
            clDone_imp.FillWeight = 57.9811935F;
            clDone_imp.HeaderText = "Done";
            clDone_imp.MinimumWidth = 6;
            clDone_imp.Name = "clDone_imp";
            clDone_imp.ReadOnly = true;
            clDone_imp.Width = 72;
            // 
            // Important
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(pnlContentImp_bottom);
            Controls.Add(pnlContentImp_center);
            Controls.Add(cpToolBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Important";
            Text = "Important";
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
        private Label lblImp_important;
        private Label lblImp_calendar;
        private TextBox txtImportantTask;
        private System.Windows.Forms.Panel pnlContentImp_bottom;
        private DataGridView tableImportant;
        private DataGridViewTextBoxColumn clTitle_imp;
        private DataGridViewTextBoxColumn clDuedate_imp;
        private DataGridViewTextBoxColumn clImportance_imp;
        private DataGridViewTextBoxColumn clDone_imp;
        private Label lblImp_importantSelected;
        private ToolTip toolTip_impCalendar;
        private ToolTip toolTip_impImportant;
        private ToolTip toolTip_impImportantSelected;
    }
}