namespace GUI.Panel
{
    partial class TaskInfo
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
            pnl_detailTitle = new System.Windows.Forms.Panel();
            lbl_doneIcon = new Label();
            lbl_iconImportant = new Label();
            txt_detailTitle = new TextBox();
            pnl_detailTop = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new Label();
            label1 = new Label();
            lblTasks_timePicker = new Label();
            btn_AddStep = new Button();
            pnl_TaskStep = new FlowLayoutPanel();
            pnl_detailDuedate = new System.Windows.Forms.Panel();
            label3 = new Label();
            lbl_detailDueDate_icon = new Label();
            lbl_detailDueDate = new Label();
            pnl_detailMiddle = new System.Windows.Forms.Panel();
            pnl_detailAddFile_Title = new System.Windows.Forms.Panel();
            lbl_detailAddFile = new Label();
            lbl_detailAddFile_icon = new Label();
            pnl_FileItems = new FlowLayoutPanel();
            txt_detailDescription = new TextBox();
            label19 = new Label();
            pnl_detailBottom = new System.Windows.Forms.Panel();
            btn_detailDelete = new Button();
            btn_detailSave = new Button();
            pnl_createdDate = new System.Windows.Forms.Panel();
            lbl_createdDate = new Label();
            label14 = new Label();
            customeDateTime1 = new Components.CustomeDateTime();
            pnl_detailTitle.SuspendLayout();
            pnl_detailTop.SuspendLayout();
            panel1.SuspendLayout();
            pnl_detailDuedate.SuspendLayout();
            pnl_detailMiddle.SuspendLayout();
            pnl_detailAddFile_Title.SuspendLayout();
            pnl_detailBottom.SuspendLayout();
            pnl_createdDate.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_detailTitle
            // 
            pnl_detailTitle.BackColor = Color.White;
            pnl_detailTitle.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailTitle.Controls.Add(lbl_doneIcon);
            pnl_detailTitle.Controls.Add(lbl_iconImportant);
            pnl_detailTitle.Controls.Add(txt_detailTitle);
            pnl_detailTitle.Location = new Point(20, 10);
            pnl_detailTitle.Margin = new Padding(0);
            pnl_detailTitle.Name = "pnl_detailTitle";
            pnl_detailTitle.Size = new Size(560, 40);
            pnl_detailTitle.TabIndex = 0;
            // 
            // lbl_doneIcon
            // 
            lbl_doneIcon.BackColor = Color.Transparent;
            lbl_doneIcon.Image = Properties.Resources.notDone_24;
            lbl_doneIcon.Location = new Point(0, 0);
            lbl_doneIcon.Margin = new Padding(0);
            lbl_doneIcon.Name = "lbl_doneIcon";
            lbl_doneIcon.Size = new Size(44, 40);
            lbl_doneIcon.TabIndex = 12;
            lbl_doneIcon.Click += lbl_doneIcon_Click;
            // 
            // lbl_iconImportant
            // 
            lbl_iconImportant.BackColor = Color.Transparent;
            lbl_iconImportant.Image = Properties.Resources.star;
            lbl_iconImportant.Location = new Point(509, 0);
            lbl_iconImportant.Margin = new Padding(0);
            lbl_iconImportant.Name = "lbl_iconImportant";
            lbl_iconImportant.Size = new Size(50, 40);
            lbl_iconImportant.TabIndex = 11;
            lbl_iconImportant.Click += lbl_iconImportant_Click;
            // 
            // txt_detailTitle
            // 
            txt_detailTitle.BackColor = Color.WhiteSmoke;
            txt_detailTitle.BorderStyle = BorderStyle.None;
            txt_detailTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailTitle.Location = new Point(44, 3);
            txt_detailTitle.Margin = new Padding(0);
            txt_detailTitle.MaxLength = 50;
            txt_detailTitle.Name = "txt_detailTitle";
            txt_detailTitle.Size = new Size(465, 32);
            txt_detailTitle.TabIndex = 10;
            txt_detailTitle.Text = "Task's Title";
            // 
            // pnl_detailTop
            // 
            pnl_detailTop.Controls.Add(panel1);
            pnl_detailTop.Controls.Add(btn_AddStep);
            pnl_detailTop.Controls.Add(pnl_TaskStep);
            pnl_detailTop.Controls.Add(pnl_detailDuedate);
            pnl_detailTop.Controls.Add(pnl_detailTitle);
            pnl_detailTop.Location = new Point(10, 9);
            pnl_detailTop.Margin = new Padding(0);
            pnl_detailTop.Name = "pnl_detailTop";
            pnl_detailTop.Size = new Size(599, 268);
            pnl_detailTop.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTasks_timePicker);
            panel1.Location = new Point(20, 215);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 40);
            panel1.TabIndex = 8;
            panel1.Click += lblTasks_timePicker_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(428, -1);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(131, 40);
            label4.TabIndex = 9;
            label4.Text = "Notification";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += lblTasks_timePicker_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = Properties.Resources.notification_32px;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(40, 40);
            label1.TabIndex = 7;
            label1.Click += lblTasks_timePicker_Click;
            // 
            // lblTasks_timePicker
            // 
            lblTasks_timePicker.BackColor = Color.Transparent;
            lblTasks_timePicker.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTasks_timePicker.Location = new Point(46, 0);
            lblTasks_timePicker.Margin = new Padding(0);
            lblTasks_timePicker.Name = "lblTasks_timePicker";
            lblTasks_timePicker.Size = new Size(381, 40);
            lblTasks_timePicker.TabIndex = 6;
            lblTasks_timePicker.Text = "10/10/2024";
            lblTasks_timePicker.TextAlign = ContentAlignment.MiddleLeft;
            lblTasks_timePicker.Click += lblTasks_timePicker_Click;
            // 
            // btn_AddStep
            // 
            btn_AddStep.AutoSize = true;
            btn_AddStep.Location = new Point(486, 129);
            btn_AddStep.Margin = new Padding(0);
            btn_AddStep.Name = "btn_AddStep";
            btn_AddStep.Size = new Size(95, 27);
            btn_AddStep.TabIndex = 4;
            btn_AddStep.Text = "Add Step";
            btn_AddStep.UseVisualStyleBackColor = true;
            btn_AddStep.Click += btn_AddStep_Click;
            // 
            // pnl_TaskStep
            // 
            pnl_TaskStep.AutoScroll = true;
            pnl_TaskStep.BorderStyle = BorderStyle.FixedSingle;
            pnl_TaskStep.Location = new Point(20, 49);
            pnl_TaskStep.Margin = new Padding(0);
            pnl_TaskStep.Name = "pnl_TaskStep";
            pnl_TaskStep.Size = new Size(560, 80);
            pnl_TaskStep.TabIndex = 3;
            // 
            // pnl_detailDuedate
            // 
            pnl_detailDuedate.BackColor = Color.White;
            pnl_detailDuedate.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailDuedate.Controls.Add(label3);
            pnl_detailDuedate.Controls.Add(lbl_detailDueDate_icon);
            pnl_detailDuedate.Controls.Add(lbl_detailDueDate);
            pnl_detailDuedate.Location = new Point(21, 164);
            pnl_detailDuedate.Margin = new Padding(0);
            pnl_detailDuedate.Name = "pnl_detailDuedate";
            pnl_detailDuedate.Size = new Size(560, 40);
            pnl_detailDuedate.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(428, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(131, 40);
            label3.TabIndex = 8;
            label3.Text = "Due date";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_detailDueDate_icon
            // 
            lbl_detailDueDate_icon.BackColor = Color.Transparent;
            lbl_detailDueDate_icon.Image = Properties.Resources.calendar;
            lbl_detailDueDate_icon.Location = new Point(0, 0);
            lbl_detailDueDate_icon.Margin = new Padding(0);
            lbl_detailDueDate_icon.Name = "lbl_detailDueDate_icon";
            lbl_detailDueDate_icon.Size = new Size(40, 40);
            lbl_detailDueDate_icon.TabIndex = 7;
            lbl_detailDueDate_icon.Click += pnl_detailDueDate_Click;
            lbl_detailDueDate_icon.MouseEnter += pnl_detailDuedate_MouseEnter;
            lbl_detailDueDate_icon.MouseLeave += pnl_detailDuedate_MouseLeave;
            // 
            // lbl_detailDueDate
            // 
            lbl_detailDueDate.BackColor = Color.Transparent;
            lbl_detailDueDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_detailDueDate.Location = new Point(46, 0);
            lbl_detailDueDate.Margin = new Padding(0);
            lbl_detailDueDate.Name = "lbl_detailDueDate";
            lbl_detailDueDate.Size = new Size(380, 40);
            lbl_detailDueDate.TabIndex = 6;
            lbl_detailDueDate.Text = "10/10/2024";
            lbl_detailDueDate.TextAlign = ContentAlignment.MiddleLeft;
            lbl_detailDueDate.Click += pnl_detailDueDate_Click;
            lbl_detailDueDate.MouseEnter += pnl_detailDuedate_MouseEnter;
            lbl_detailDueDate.MouseLeave += pnl_detailDuedate_MouseLeave;
            // 
            // pnl_detailMiddle
            // 
            pnl_detailMiddle.Controls.Add(pnl_detailAddFile_Title);
            pnl_detailMiddle.Controls.Add(pnl_FileItems);
            pnl_detailMiddle.Controls.Add(txt_detailDescription);
            pnl_detailMiddle.Controls.Add(label19);
            pnl_detailMiddle.Location = new Point(9, 277);
            pnl_detailMiddle.Margin = new Padding(0);
            pnl_detailMiddle.Name = "pnl_detailMiddle";
            pnl_detailMiddle.Size = new Size(600, 360);
            pnl_detailMiddle.TabIndex = 2;
            // 
            // pnl_detailAddFile_Title
            // 
            pnl_detailAddFile_Title.BackColor = Color.White;
            pnl_detailAddFile_Title.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailAddFile_Title.Controls.Add(lbl_detailAddFile);
            pnl_detailAddFile_Title.Controls.Add(lbl_detailAddFile_icon);
            pnl_detailAddFile_Title.Location = new Point(21, 10);
            pnl_detailAddFile_Title.Margin = new Padding(0);
            pnl_detailAddFile_Title.Name = "pnl_detailAddFile_Title";
            pnl_detailAddFile_Title.Size = new Size(560, 40);
            pnl_detailAddFile_Title.TabIndex = 3;
            pnl_detailAddFile_Title.Click += pnl_detailAddFile_Title_Click;
            // 
            // lbl_detailAddFile
            // 
            lbl_detailAddFile.BackColor = Color.Transparent;
            lbl_detailAddFile.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_detailAddFile.Location = new Point(46, 0);
            lbl_detailAddFile.Margin = new Padding(0);
            lbl_detailAddFile.Name = "lbl_detailAddFile";
            lbl_detailAddFile.Size = new Size(512, 40);
            lbl_detailAddFile.TabIndex = 6;
            lbl_detailAddFile.Text = "Add file";
            lbl_detailAddFile.TextAlign = ContentAlignment.MiddleLeft;
            lbl_detailAddFile.Click += pnl_detailAddFile_Title_Click;
            lbl_detailAddFile.MouseEnter += pnl_detailAddFile_MouseEnter;
            lbl_detailAddFile.MouseLeave += pnl_detailAddFile_MouseLeave;
            // 
            // lbl_detailAddFile_icon
            // 
            lbl_detailAddFile_icon.BackColor = Color.Transparent;
            lbl_detailAddFile_icon.Image = Properties.Resources.sort2;
            lbl_detailAddFile_icon.Location = new Point(0, 0);
            lbl_detailAddFile_icon.Margin = new Padding(0);
            lbl_detailAddFile_icon.Name = "lbl_detailAddFile_icon";
            lbl_detailAddFile_icon.Size = new Size(46, 40);
            lbl_detailAddFile_icon.TabIndex = 7;
            lbl_detailAddFile_icon.Click += pnl_detailAddFile_Title_Click;
            lbl_detailAddFile_icon.MouseEnter += pnl_detailAddFile_MouseEnter;
            lbl_detailAddFile_icon.MouseLeave += pnl_detailAddFile_MouseLeave;
            // 
            // pnl_FileItems
            // 
            pnl_FileItems.AutoScroll = true;
            pnl_FileItems.BorderStyle = BorderStyle.FixedSingle;
            pnl_FileItems.Location = new Point(21, 50);
            pnl_FileItems.Margin = new Padding(0);
            pnl_FileItems.Name = "pnl_FileItems";
            pnl_FileItems.Size = new Size(560, 130);
            pnl_FileItems.TabIndex = 13;
            // 
            // txt_detailDescription
            // 
            txt_detailDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailDescription.Location = new Point(21, 231);
            txt_detailDescription.Margin = new Padding(0);
            txt_detailDescription.MaxLength = 255;
            txt_detailDescription.Multiline = true;
            txt_detailDescription.Name = "txt_detailDescription";
            txt_detailDescription.ScrollBars = ScrollBars.Vertical;
            txt_detailDescription.Size = new Size(560, 122);
            txt_detailDescription.TabIndex = 17;
            txt_detailDescription.Text = "......";
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(21, 191);
            label19.Margin = new Padding(0);
            label19.Name = "label19";
            label19.Size = new Size(560, 40);
            label19.TabIndex = 16;
            label19.Text = "Decription";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_detailBottom
            // 
            pnl_detailBottom.Controls.Add(btn_detailDelete);
            pnl_detailBottom.Controls.Add(btn_detailSave);
            pnl_detailBottom.Controls.Add(pnl_createdDate);
            pnl_detailBottom.Location = new Point(10, 640);
            pnl_detailBottom.Name = "pnl_detailBottom";
            pnl_detailBottom.Size = new Size(600, 59);
            pnl_detailBottom.TabIndex = 3;
            // 
            // btn_detailDelete
            // 
            btn_detailDelete.BackColor = Color.Tomato;
            btn_detailDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_detailDelete.Image = Properties.Resources.bin1;
            btn_detailDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_detailDelete.Location = new Point(450, 12);
            btn_detailDelete.Margin = new Padding(0);
            btn_detailDelete.Name = "btn_detailDelete";
            btn_detailDelete.Padding = new Padding(10, 0, 10, 0);
            btn_detailDelete.Size = new Size(127, 43);
            btn_detailDelete.TabIndex = 19;
            btn_detailDelete.Text = "Delete";
            btn_detailDelete.TextAlign = ContentAlignment.MiddleRight;
            btn_detailDelete.UseVisualStyleBackColor = false;
            btn_detailDelete.Click += btn_detailDelete_Click;
            // 
            // btn_detailSave
            // 
            btn_detailSave.BackColor = Color.YellowGreen;
            btn_detailSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_detailSave.Image = Properties.Resources.notDone_24;
            btn_detailSave.ImageAlign = ContentAlignment.MiddleLeft;
            btn_detailSave.Location = new Point(15, 12);
            btn_detailSave.Margin = new Padding(0);
            btn_detailSave.Name = "btn_detailSave";
            btn_detailSave.Padding = new Padding(20, 0, 20, 0);
            btn_detailSave.Size = new Size(127, 43);
            btn_detailSave.TabIndex = 18;
            btn_detailSave.Text = "Save";
            btn_detailSave.TextAlign = ContentAlignment.MiddleRight;
            btn_detailSave.UseVisualStyleBackColor = false;
            btn_detailSave.Click += btn_detailSave_Click;
            // 
            // pnl_createdDate
            // 
            pnl_createdDate.Controls.Add(lbl_createdDate);
            pnl_createdDate.Controls.Add(label14);
            pnl_createdDate.Location = new Point(134, 15);
            pnl_createdDate.Name = "pnl_createdDate";
            pnl_createdDate.Size = new Size(314, 40);
            pnl_createdDate.TabIndex = 9;
            // 
            // lbl_createdDate
            // 
            lbl_createdDate.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_createdDate.Location = new Point(118, 10);
            lbl_createdDate.Name = "lbl_createdDate";
            lbl_createdDate.Size = new Size(183, 21);
            lbl_createdDate.TabIndex = 1;
            lbl_createdDate.Text = "Friday, November 15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(32, 10);
            label14.Name = "label14";
            label14.Size = new Size(90, 21);
            label14.TabIndex = 0;
            label14.Text = "Created on:";
            // 
            // customeDateTime1
            // 
            customeDateTime1.Location = new Point(34, 265);
            customeDateTime1.Margin = new Padding(3, 2, 3, 2);
            customeDateTime1.Name = "customeDateTime1";
            customeDateTime1.Size = new Size(228, 294);
            customeDateTime1.TabIndex = 0;
            // 
            // TaskInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 711);
            Controls.Add(customeDateTime1);
            Controls.Add(pnl_detailBottom);
            Controls.Add(pnl_detailMiddle);
            Controls.Add(pnl_detailTop);
            Name = "TaskInfo";
            Text = "TaskInfo";
            pnl_detailTitle.ResumeLayout(false);
            pnl_detailTitle.PerformLayout();
            pnl_detailTop.ResumeLayout(false);
            pnl_detailTop.PerformLayout();
            panel1.ResumeLayout(false);
            pnl_detailDuedate.ResumeLayout(false);
            pnl_detailMiddle.ResumeLayout(false);
            pnl_detailMiddle.PerformLayout();
            pnl_detailAddFile_Title.ResumeLayout(false);
            pnl_detailBottom.ResumeLayout(false);
            pnl_createdDate.ResumeLayout(false);
            pnl_createdDate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_detailTitle;
        private Label lbl_iconImportant;
        private TextBox txt_detailTitle;
        private System.Windows.Forms.Panel pnl_detailTop;
        private System.Windows.Forms.Panel pnl_detailDuedate;
        private Label lbl_detailDueDate_icon;
        private Label lbl_detailDueDate;
        private System.Windows.Forms.Panel pnl_detailMiddle;
        private System.Windows.Forms.Panel pnl_detailAddFile_Title;
        private Label lbl_detailAddFile_icon;
        private Label lbl_detailAddFile;
        private FlowLayoutPanel pnl_FileItems;
        private TextBox txt_detailDescription;
        private Label label19;
        private System.Windows.Forms.Panel pnl_detailBottom;
        private System.Windows.Forms.Panel pnl_createdDate;
        private Label lbl_createdDate;
        private Label label14;
        private Label lbl_doneIcon;
        private Button btn_detailSave;
        private Button btn_detailDelete;
        private FlowLayoutPanel pnl_TaskStep;
        private Button btn_AddStep;
        private System.Windows.Forms.Panel panel1;
        private Label label1;
        private Label lblTasks_timePicker;
        private Label label4;
        private Label label3;
        private Components.CustomeDateTime customeDateTime1;
    }
}