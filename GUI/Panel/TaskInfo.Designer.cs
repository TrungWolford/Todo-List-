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
            lbl_iconImportant = new Label();
            txt_detailTitle = new TextBox();
            pnl_detailTop = new System.Windows.Forms.Panel();
            pnl_detailDuedate = new System.Windows.Forms.Panel();
            lbl_detailDueDate_icon = new Label();
            lbl_detailDueDate = new Label();
            pnl_detailMiddle = new System.Windows.Forms.Panel();
            pnl_FileItems = new FlowLayoutPanel();
            pnl_detailAddFile_Title = new System.Windows.Forms.Panel();
            lbl_detailAddFile_icon = new Label();
            lbl_detailAddFile = new Label();
            txt_detailDescription = new TextBox();
            label19 = new Label();
            pnl_detailBottom = new System.Windows.Forms.Panel();
            pnl_createdDate = new System.Windows.Forms.Panel();
            lbl_createdDate = new Label();
            label14 = new Label();
            pnl_deleteBtn = new System.Windows.Forms.Panel();
            label12 = new Label();
            label13 = new Label();
            pnl_saveBtn = new System.Windows.Forms.Panel();
            label20 = new Label();
            label21 = new Label();
            pnl_detailTitle.SuspendLayout();
            pnl_detailTop.SuspendLayout();
            pnl_detailDuedate.SuspendLayout();
            pnl_detailMiddle.SuspendLayout();
            pnl_detailAddFile_Title.SuspendLayout();
            pnl_detailBottom.SuspendLayout();
            pnl_createdDate.SuspendLayout();
            pnl_deleteBtn.SuspendLayout();
            pnl_saveBtn.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_detailTitle
            // 
            pnl_detailTitle.BackColor = Color.White;
            pnl_detailTitle.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailTitle.Controls.Add(lbl_iconImportant);
            pnl_detailTitle.Controls.Add(txt_detailTitle);
            pnl_detailTitle.Location = new Point(23, 13);
            pnl_detailTitle.Margin = new Padding(0);
            pnl_detailTitle.Name = "pnl_detailTitle";
            pnl_detailTitle.Size = new Size(640, 53);
            pnl_detailTitle.TabIndex = 0;
            // 
            // lbl_iconImportant
            // 
            lbl_iconImportant.Image = Properties.Resources.star;
            lbl_iconImportant.Location = new Point(582, 0);
            lbl_iconImportant.Margin = new Padding(0);
            lbl_iconImportant.Name = "lbl_iconImportant";
            lbl_iconImportant.Size = new Size(57, 53);
            lbl_iconImportant.TabIndex = 11;
            // 
            // txt_detailTitle
            // 
            txt_detailTitle.BackColor = Color.WhiteSmoke;
            txt_detailTitle.BorderStyle = BorderStyle.None;
            txt_detailTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailTitle.Location = new Point(0, 4);
            txt_detailTitle.Margin = new Padding(0);
            txt_detailTitle.MaxLength = 50;
            txt_detailTitle.Name = "txt_detailTitle";
            txt_detailTitle.Size = new Size(582, 40);
            txt_detailTitle.TabIndex = 10;
            txt_detailTitle.Text = "Task's Title";
            // 
            // pnl_detailTop
            // 
            pnl_detailTop.Controls.Add(pnl_detailDuedate);
            pnl_detailTop.Controls.Add(pnl_detailTitle);
            pnl_detailTop.Location = new Point(11, 28);
            pnl_detailTop.Margin = new Padding(0);
            pnl_detailTop.Name = "pnl_detailTop";
            pnl_detailTop.Size = new Size(686, 147);
            pnl_detailTop.TabIndex = 1;
            // 
            // pnl_detailDuedate
            // 
            pnl_detailDuedate.BackColor = Color.White;
            pnl_detailDuedate.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailDuedate.Controls.Add(lbl_detailDueDate_icon);
            pnl_detailDuedate.Controls.Add(lbl_detailDueDate);
            pnl_detailDuedate.Location = new Point(23, 79);
            pnl_detailDuedate.Margin = new Padding(0);
            pnl_detailDuedate.Name = "pnl_detailDuedate";
            pnl_detailDuedate.Size = new Size(640, 53);
            pnl_detailDuedate.TabIndex = 2;
            // 
            // lbl_detailDueDate_icon
            // 


            lbl_detailDueDate_icon.Image = Properties.Resources.calendar;
            lbl_detailDueDate_icon.Location = new Point(0, 0);
            lbl_detailDueDate_icon.Margin = new Padding(0);
            lbl_detailDueDate_icon.Name = "lbl_detailDueDate_icon";
            lbl_detailDueDate_icon.Size = new Size(46, 40);
            lbl_detailDueDate_icon.TabIndex = 7;
            lbl_detailDueDate_icon.Click += pnl_detailDueDate_Click;

            // 
            // lbl_detailDueDate
            // 
            lbl_detailDueDate.BackColor = Color.White;
            lbl_detailDueDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_detailDueDate.Location = new Point(53, 0);
            lbl_detailDueDate.Margin = new Padding(0);
            lbl_detailDueDate.Name = "lbl_detailDueDate";
            lbl_detailDueDate.Size = new Size(587, 53);
            lbl_detailDueDate.TabIndex = 6;
            lbl_detailDueDate.Text = "10/10/2024";
            lbl_detailDueDate.TextAlign = ContentAlignment.MiddleLeft;
            lbl_detailDueDate.Click += pnl_detailDueDate_Click;
            // 
            // pnl_detailMiddle
            // 
            pnl_detailMiddle.Controls.Add(pnl_FileItems);
            pnl_detailMiddle.Controls.Add(pnl_detailAddFile_Title);
            pnl_detailMiddle.Controls.Add(txt_detailDescription);
            pnl_detailMiddle.Controls.Add(label19);
            pnl_detailMiddle.Location = new Point(11, 197);
            pnl_detailMiddle.Margin = new Padding(0);
            pnl_detailMiddle.Name = "pnl_detailMiddle";
            pnl_detailMiddle.Size = new Size(686, 577);
            pnl_detailMiddle.TabIndex = 2;
            // 
            // pnl_FileItems
            // 
            pnl_FileItems.AutoScroll = true;
            pnl_FileItems.BorderStyle = BorderStyle.FixedSingle;
            pnl_FileItems.Location = new Point(23, 77);
            pnl_FileItems.Margin = new Padding(0);
            pnl_FileItems.Name = "pnl_FileItems";
            pnl_FileItems.Size = new Size(640, 227);
            pnl_FileItems.TabIndex = 13;
            // 
            // pnl_detailAddFile_Title
            // 
            pnl_detailAddFile_Title.BorderStyle = BorderStyle.FixedSingle;

            pnl_detailAddFile_Title.Controls.Add(lbl_detailAddFile_icon);
            pnl_detailAddFile_Title.Controls.Add(lbl_detailAddFile);
            pnl_detailAddFile_Title.Location = new Point(20, 12);

            pnl_detailAddFile_Title.Margin = new Padding(0);
            pnl_detailAddFile_Title.Name = "pnl_detailAddFile_Title";
            pnl_detailAddFile_Title.Size = new Size(640, 53);
            pnl_detailAddFile_Title.TabIndex = 3;
            pnl_detailAddFile_Title.Click += pnl_detailAddFile_Title_Click;
            // 
            // lbl_detailAddFile_icon
            // 

            lbl_detailAddFile_icon.BackColor = Color.White;
            lbl_detailAddFile_icon.Image = Properties.Resources.sort2;
            lbl_detailAddFile_icon.Location = new Point(0, 0);
            lbl_detailAddFile_icon.Margin = new Padding(0);
            lbl_detailAddFile_icon.Name = "lbl_detailAddFile_icon";
            lbl_detailAddFile_icon.Size = new Size(52, 40);
            lbl_detailAddFile_icon.TabIndex = 7;
            lbl_detailAddFile_icon.Click += pnl_detailAddFile_Title_Click;
            // 
            // lbl_detailAddFile
            // 

            lbl_detailAddFile.BackColor = Color.White;
            lbl_detailAddFile.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_detailAddFile.Location = new Point(52, 0);
            lbl_detailAddFile.Margin = new Padding(0);
            lbl_detailAddFile.Name = "lbl_detailAddFile";
            lbl_detailAddFile.Size = new Size(508, 40);
            lbl_detailAddFile.TabIndex = 6;
            lbl_detailAddFile.Text = "Add file";
            lbl_detailAddFile.TextAlign = ContentAlignment.MiddleLeft;
            lbl_detailAddFile.Click += pnl_detailAddFile_Title_Click;
            // 
            // txt_detailDescription
            // 
            txt_detailDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailDescription.Location = new Point(23, 395);
            txt_detailDescription.Margin = new Padding(0);
            txt_detailDescription.MaxLength = 255;
            txt_detailDescription.Multiline = true;
            txt_detailDescription.Name = "txt_detailDescription";
            txt_detailDescription.ScrollBars = ScrollBars.Vertical;
            txt_detailDescription.Size = new Size(639, 161);
            txt_detailDescription.TabIndex = 17;
            txt_detailDescription.Text = "......";
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(23, 333);
            label19.Margin = new Padding(0);
            label19.Name = "label19";
            label19.Size = new Size(640, 53);
            label19.TabIndex = 16;
            label19.Text = "Decription";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_detailBottom
            // 
            pnl_detailBottom.Controls.Add(pnl_createdDate);
            pnl_detailBottom.Controls.Add(pnl_deleteBtn);
            pnl_detailBottom.Controls.Add(pnl_saveBtn);
            pnl_detailBottom.Location = new Point(11, 792);
            pnl_detailBottom.Margin = new Padding(3, 4, 3, 4);
            pnl_detailBottom.Name = "pnl_detailBottom";
            pnl_detailBottom.Size = new Size(686, 140);
            pnl_detailBottom.TabIndex = 3;
            // 
            // pnl_createdDate
            // 
            pnl_createdDate.Controls.Add(lbl_createdDate);
            pnl_createdDate.Controls.Add(label14);
            pnl_createdDate.Location = new Point(144, 83);
            pnl_createdDate.Margin = new Padding(3, 4, 3, 4);
            pnl_createdDate.Name = "pnl_createdDate";
            pnl_createdDate.Size = new Size(386, 53);
            pnl_createdDate.TabIndex = 9;
            // 
            // lbl_createdDate
            // 
            lbl_createdDate.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_createdDate.Location = new Point(153, 13);
            lbl_createdDate.Name = "lbl_createdDate";
            lbl_createdDate.Size = new Size(209, 28);
            lbl_createdDate.TabIndex = 1;
            lbl_createdDate.Text = "Friday, November 15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(54, 13);
            label14.Name = "label14";
            label14.Size = new Size(112, 28);
            label14.TabIndex = 0;
            label14.Text = "Created on:";
            // 
            // pnl_deleteBtn
            // 
            pnl_deleteBtn.BackColor = Color.Azure;
            pnl_deleteBtn.Controls.Add(label12);
            pnl_deleteBtn.Controls.Add(label13);
            pnl_deleteBtn.Location = new Point(550, 83);
            pnl_deleteBtn.Margin = new Padding(3, 4, 3, 4);
            pnl_deleteBtn.Name = "pnl_deleteBtn";
            pnl_deleteBtn.Size = new Size(133, 53);
            pnl_deleteBtn.TabIndex = 8;
            // 
            // label12
            // 
            label12.Image = Properties.Resources.calendar;
            label12.Location = new Point(0, 0);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(59, 53);
            label12.TabIndex = 7;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(59, 0);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.Size = new Size(73, 53);
            label13.TabIndex = 6;
            label13.Text = "Delete";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_saveBtn
            // 
            pnl_saveBtn.BackColor = Color.Azure;
            pnl_saveBtn.Controls.Add(label20);
            pnl_saveBtn.Controls.Add(label21);
            pnl_saveBtn.Location = new Point(5, 83);
            pnl_saveBtn.Margin = new Padding(3, 4, 3, 4);
            pnl_saveBtn.Name = "pnl_saveBtn";
            pnl_saveBtn.Size = new Size(133, 53);
            pnl_saveBtn.TabIndex = 0;
            // 
            // label20
            // 
            label20.Image = Properties.Resources.calendar;
            label20.Location = new Point(0, 0);
            label20.Margin = new Padding(0);
            label20.Name = "label20";
            label20.Size = new Size(59, 53);
            label20.TabIndex = 7;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(59, 0);
            label21.Margin = new Padding(0);
            label21.Name = "label21";
            label21.Size = new Size(73, 53);
            label21.TabIndex = 6;
            label21.Text = "Save";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TaskInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 948);
            Controls.Add(pnl_detailBottom);
            Controls.Add(pnl_detailMiddle);
            Controls.Add(pnl_detailTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskInfo";
            Text = "TaskInfo";
            pnl_detailTitle.ResumeLayout(false);
            pnl_detailTitle.PerformLayout();
            pnl_detailTop.ResumeLayout(false);
            pnl_detailDuedate.ResumeLayout(false);
            pnl_detailMiddle.ResumeLayout(false);
            pnl_detailMiddle.PerformLayout();
            pnl_detailAddFile_Title.ResumeLayout(false);
            pnl_detailBottom.ResumeLayout(false);
            pnl_createdDate.ResumeLayout(false);
            pnl_createdDate.PerformLayout();
            pnl_deleteBtn.ResumeLayout(false);
            pnl_saveBtn.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnl_saveBtn;
        private Label label20;
        private Label label21;
        private System.Windows.Forms.Panel pnl_deleteBtn;
        private Label label12;
        private Label label13;
        private System.Windows.Forms.Panel pnl_createdDate;
        private Label lbl_createdDate;
        private Label label14;
    }
}