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
            label1 = new Label();
            lbl_detailDueDate = new Label();
            pnl_detailMiddle = new System.Windows.Forms.Panel();
            pnl_detailAddFile_Title = new System.Windows.Forms.Panel();
            label2 = new Label();
            label3 = new Label();
            pnl_FileItems = new FlowLayoutPanel();
            txt_detailDescription = new TextBox();
            label19 = new Label();
            pnl_detailBottom = new System.Windows.Forms.Panel();
            pnl_saveBtn = new System.Windows.Forms.Panel();
            label20 = new Label();
            label21 = new Label();
            pnl_attachItem = new System.Windows.Forms.Panel();
            lbl_FileName = new Label();
            lbl_FileRemoveBtn = new Label();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new Label();
            label5 = new Label();
            panel2 = new System.Windows.Forms.Panel();
            label6 = new Label();
            label7 = new Label();
            panel3 = new System.Windows.Forms.Panel();
            label8 = new Label();
            label9 = new Label();
            panel4 = new System.Windows.Forms.Panel();
            label10 = new Label();
            label11 = new Label();
            pnl_deleteBtn = new System.Windows.Forms.Panel();
            label12 = new Label();
            label13 = new Label();
            pnl_createdDate = new System.Windows.Forms.Panel();
            label14 = new Label();
            lbl_createdDate = new Label();
            pnl_detailTitle.SuspendLayout();
            pnl_detailTop.SuspendLayout();
            pnl_detailDuedate.SuspendLayout();
            pnl_detailMiddle.SuspendLayout();
            pnl_detailAddFile_Title.SuspendLayout();
            pnl_FileItems.SuspendLayout();
            pnl_detailBottom.SuspendLayout();
            pnl_saveBtn.SuspendLayout();
            pnl_attachItem.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pnl_deleteBtn.SuspendLayout();
            pnl_createdDate.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_detailTitle
            // 
            pnl_detailTitle.BackColor = Color.White;
            pnl_detailTitle.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailTitle.Controls.Add(lbl_iconImportant);
            pnl_detailTitle.Controls.Add(txt_detailTitle);
            pnl_detailTitle.Location = new Point(20, 10);
            pnl_detailTitle.Margin = new Padding(0, 0, 0, 0);
            pnl_detailTitle.Name = "pnl_detailTitle";
            pnl_detailTitle.Size = new Size(560, 40);
            pnl_detailTitle.TabIndex = 0;
            // 
            // lbl_iconImportant
            // 
            lbl_iconImportant.Image = Properties.Resources.star;
            lbl_iconImportant.Location = new Point(509, 0);
            lbl_iconImportant.Margin = new Padding(0);
            lbl_iconImportant.Name = "lbl_iconImportant";
            lbl_iconImportant.Size = new Size(50, 40);
            lbl_iconImportant.TabIndex = 11;
            // 
            // txt_detailTitle
            // 
            txt_detailTitle.BackColor = Color.WhiteSmoke;
            txt_detailTitle.BorderStyle = BorderStyle.None;
            txt_detailTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailTitle.Location = new Point(0, 3);
            txt_detailTitle.Margin = new Padding(0);
            txt_detailTitle.MaxLength = 50;
            txt_detailTitle.Name = "txt_detailTitle";
            txt_detailTitle.Size = new Size(509, 32);
            txt_detailTitle.TabIndex = 10;
            txt_detailTitle.Text = "Task's Title";
            // 
            // pnl_detailTop
            // 
            pnl_detailTop.Controls.Add(pnl_detailDuedate);
            pnl_detailTop.Controls.Add(pnl_detailTitle);
            pnl_detailTop.Location = new Point(10, 21);
            pnl_detailTop.Margin = new Padding(0, 0, 0, 0);
            pnl_detailTop.Name = "pnl_detailTop";
            pnl_detailTop.Size = new Size(600, 110);
            pnl_detailTop.TabIndex = 1;
            // 
            // pnl_detailDuedate
            // 
            pnl_detailDuedate.BackColor = Color.White;
            pnl_detailDuedate.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailDuedate.Controls.Add(label1);
            pnl_detailDuedate.Controls.Add(lbl_detailDueDate);
            pnl_detailDuedate.Location = new Point(20, 59);
            pnl_detailDuedate.Margin = new Padding(0, 0, 0, 0);
            pnl_detailDuedate.Name = "pnl_detailDuedate";
            pnl_detailDuedate.Size = new Size(560, 40);
            pnl_detailDuedate.TabIndex = 2;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.calendar;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(46, 40);
            label1.TabIndex = 7;
            // 
            // lbl_detailDueDate
            // 
            lbl_detailDueDate.BackColor = Color.White;
            lbl_detailDueDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_detailDueDate.Location = new Point(46, 0);
            lbl_detailDueDate.Margin = new Padding(0);
            lbl_detailDueDate.Name = "lbl_detailDueDate";
            lbl_detailDueDate.Size = new Size(514, 40);
            lbl_detailDueDate.TabIndex = 6;
            lbl_detailDueDate.Text = "10/10/2024";
            lbl_detailDueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_detailMiddle
            // 
            pnl_detailMiddle.Controls.Add(pnl_FileItems);
            pnl_detailMiddle.Controls.Add(pnl_detailAddFile_Title);
            pnl_detailMiddle.Controls.Add(txt_detailDescription);
            pnl_detailMiddle.Controls.Add(label19);
            pnl_detailMiddle.Location = new Point(10, 148);
            pnl_detailMiddle.Margin = new Padding(0, 0, 0, 0);
            pnl_detailMiddle.Name = "pnl_detailMiddle";
            pnl_detailMiddle.Size = new Size(600, 433);
            pnl_detailMiddle.TabIndex = 2;
            // 
            // pnl_detailAddFile_Title
            // 
            pnl_detailAddFile_Title.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailAddFile_Title.Controls.Add(label2);
            pnl_detailAddFile_Title.Controls.Add(label3);
            pnl_detailAddFile_Title.Location = new Point(20, 12);
            pnl_detailAddFile_Title.Margin = new Padding(0, 0, 0, 0);
            pnl_detailAddFile_Title.Name = "pnl_detailAddFile_Title";
            pnl_detailAddFile_Title.Size = new Size(560, 40);
            pnl_detailAddFile_Title.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Image = Properties.Resources.sort2;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(52, 40);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(508, 40);
            label3.TabIndex = 6;
            label3.Text = "Add file";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_FileItems
            // 
            pnl_FileItems.AutoScroll = true;
            pnl_FileItems.BorderStyle = BorderStyle.FixedSingle;
            pnl_FileItems.Controls.Add(pnl_attachItem);
            pnl_FileItems.Controls.Add(panel1);
            pnl_FileItems.Controls.Add(panel2);
            pnl_FileItems.Controls.Add(panel3);
            pnl_FileItems.Controls.Add(panel4);
            pnl_FileItems.Location = new Point(20, 58);
            pnl_FileItems.Margin = new Padding(0);
            pnl_FileItems.Name = "pnl_FileItems";
            pnl_FileItems.Size = new Size(560, 171);
            pnl_FileItems.TabIndex = 13;
            // 
            // txt_detailDescription
            // 
            txt_detailDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailDescription.Location = new Point(20, 296);
            txt_detailDescription.Margin = new Padding(0);
            txt_detailDescription.MaxLength = 255;
            txt_detailDescription.Multiline = true;
            txt_detailDescription.Name = "txt_detailDescription";
            txt_detailDescription.ScrollBars = ScrollBars.Vertical;
            txt_detailDescription.Size = new Size(560, 122);
            txt_detailDescription.TabIndex = 17;
            txt_detailDescription.Text = "Test Descriptiondsadasdsadasdsaaaaaaaaaaadsdasdasdasdasdasdsadsadasdaadasdasdsa";
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(20, 250);
            label19.Margin = new Padding(0);
            label19.Name = "label19";
            label19.Size = new Size(560, 40);
            label19.TabIndex = 16;
            label19.Text = "Decription";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_detailBottom
            // 
            pnl_detailBottom.Controls.Add(pnl_createdDate);
            pnl_detailBottom.Controls.Add(pnl_deleteBtn);
            pnl_detailBottom.Controls.Add(pnl_saveBtn);
            pnl_detailBottom.Location = new Point(10, 594);
            pnl_detailBottom.Name = "pnl_detailBottom";
            pnl_detailBottom.Size = new Size(600, 105);
            pnl_detailBottom.TabIndex = 3;
            // 
            // pnl_saveBtn
            // 
            pnl_saveBtn.BackColor = Color.Azure;
            pnl_saveBtn.Controls.Add(label20);
            pnl_saveBtn.Controls.Add(label21);
            pnl_saveBtn.Location = new Point(4, 62);
            pnl_saveBtn.Name = "pnl_saveBtn";
            pnl_saveBtn.Size = new Size(116, 40);
            pnl_saveBtn.TabIndex = 0;
            // 
            // label20
            // 
            label20.Image = Properties.Resources.calendar;
            label20.Location = new Point(0, 0);
            label20.Margin = new Padding(0);
            label20.Name = "label20";
            label20.Size = new Size(52, 40);
            label20.TabIndex = 7;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(52, 0);
            label21.Margin = new Padding(0);
            label21.Name = "label21";
            label21.Size = new Size(64, 40);
            label21.TabIndex = 6;
            label21.Text = "Save";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_attachItem
            // 
            pnl_attachItem.BorderStyle = BorderStyle.FixedSingle;
            pnl_attachItem.Controls.Add(lbl_FileName);
            pnl_attachItem.Controls.Add(lbl_FileRemoveBtn);
            pnl_attachItem.Location = new Point(0, 0);
            pnl_attachItem.Margin = new Padding(0);
            pnl_attachItem.Name = "pnl_attachItem";
            pnl_attachItem.Size = new Size(540, 40);
            pnl_attachItem.TabIndex = 17;
            // 
            // lbl_FileName
            // 
            lbl_FileName.BackColor = Color.White;
            lbl_FileName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FileName.Location = new Point(0, 0);
            lbl_FileName.Margin = new Padding(0);
            lbl_FileName.Name = "lbl_FileName";
            lbl_FileName.Size = new Size(500, 40);
            lbl_FileName.TabIndex = 12;
            lbl_FileName.Text = "CoDau8Tuoi.pdf";
            lbl_FileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_FileRemoveBtn
            // 
            lbl_FileRemoveBtn.BackColor = Color.Red;
            lbl_FileRemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_FileRemoveBtn.ForeColor = Color.White;
            lbl_FileRemoveBtn.Location = new Point(500, 0);
            lbl_FileRemoveBtn.Margin = new Padding(0);
            lbl_FileRemoveBtn.Name = "lbl_FileRemoveBtn";
            lbl_FileRemoveBtn.Size = new Size(40, 40);
            lbl_FileRemoveBtn.TabIndex = 14;
            lbl_FileRemoveBtn.Text = "X";
            lbl_FileRemoveBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 40);
            panel1.TabIndex = 18;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(500, 40);
            label4.TabIndex = 12;
            label4.Text = "CoDau8Tuoi.pdf";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Red;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(500, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(40, 40);
            label5.TabIndex = 14;
            label5.Text = "X";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 80);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 40);
            panel2.TabIndex = 19;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(500, 40);
            label6.TabIndex = 12;
            label6.Text = "CoDau8Tuoi.pdf";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.Red;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(500, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(40, 40);
            label7.TabIndex = 14;
            label7.Text = "X";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(0, 120);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 40);
            panel3.TabIndex = 20;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(500, 40);
            label8.TabIndex = 12;
            label8.Text = "CoDau8Tuoi.pdf";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Red;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(500, 0);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(40, 40);
            label9.TabIndex = 14;
            label9.Text = "X";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(0, 160);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(540, 40);
            panel4.TabIndex = 21;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(500, 40);
            label10.TabIndex = 12;
            label10.Text = "CoDau8Tuoi.pdf";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = Color.Red;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(500, 0);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(40, 40);
            label11.TabIndex = 14;
            label11.Text = "X";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_deleteBtn
            // 
            pnl_deleteBtn.BackColor = Color.Azure;
            pnl_deleteBtn.Controls.Add(label12);
            pnl_deleteBtn.Controls.Add(label13);
            pnl_deleteBtn.Location = new Point(481, 62);
            pnl_deleteBtn.Name = "pnl_deleteBtn";
            pnl_deleteBtn.Size = new Size(116, 40);
            pnl_deleteBtn.TabIndex = 8;
            // 
            // label12
            // 
            label12.Image = Properties.Resources.calendar;
            label12.Location = new Point(0, 0);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(52, 40);
            label12.TabIndex = 7;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(52, 0);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.Size = new Size(64, 40);
            label13.TabIndex = 6;
            label13.Text = "Delete";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_createdDate
            // 
            pnl_createdDate.Controls.Add(lbl_createdDate);
            pnl_createdDate.Controls.Add(label14);
            pnl_createdDate.Location = new Point(126, 62);
            pnl_createdDate.Name = "pnl_createdDate";
            pnl_createdDate.Size = new Size(338, 40);
            pnl_createdDate.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(47, 10);
            label14.Name = "label14";
            label14.Size = new Size(90, 21);
            label14.TabIndex = 0;
            label14.Text = "Created on:";
            // 
            // lbl_createdDate
            // 
            lbl_createdDate.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_createdDate.Location = new Point(134, 10);
            lbl_createdDate.Name = "lbl_createdDate";
            lbl_createdDate.Size = new Size(183, 21);
            lbl_createdDate.TabIndex = 1;
            lbl_createdDate.Text = "Friday, November 15";
            // 
            // TaskInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 711);
            Controls.Add(pnl_detailBottom);
            Controls.Add(pnl_detailMiddle);
            Controls.Add(pnl_detailTop);
            Name = "TaskInfo";
            Text = "TaskInfo";
            pnl_detailTitle.ResumeLayout(false);
            pnl_detailTitle.PerformLayout();
            pnl_detailTop.ResumeLayout(false);
            pnl_detailDuedate.ResumeLayout(false);
            pnl_detailMiddle.ResumeLayout(false);
            pnl_detailMiddle.PerformLayout();
            pnl_detailAddFile_Title.ResumeLayout(false);
            pnl_FileItems.ResumeLayout(false);
            pnl_detailBottom.ResumeLayout(false);
            pnl_saveBtn.ResumeLayout(false);
            pnl_attachItem.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnl_deleteBtn.ResumeLayout(false);
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
        private Label label1;
        private Label lbl_detailDueDate;
        private System.Windows.Forms.Panel pnl_detailMiddle;
        private System.Windows.Forms.Panel pnl_detailAddFile_Title;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel pnl_FileItems;
        private TextBox txt_detailDescription;
        private Label label19;
        private System.Windows.Forms.Panel pnl_detailBottom;
        private System.Windows.Forms.Panel pnl_saveBtn;
        private Label label20;
        private Label label21;
        private System.Windows.Forms.Panel pnl_attachItem;
        private Label lbl_FileName;
        private Label lbl_FileRemoveBtn;
        private System.Windows.Forms.Panel panel1;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Panel panel2;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.Panel panel3;
        private Label label8;
        private Label label9;
        private System.Windows.Forms.Panel panel4;
        private Label label10;
        private Label label11;
        private System.Windows.Forms.Panel pnl_deleteBtn;
        private Label label12;
        private Label label13;
        private System.Windows.Forms.Panel pnl_createdDate;
        private Label lbl_createdDate;
        private Label label14;
    }
}