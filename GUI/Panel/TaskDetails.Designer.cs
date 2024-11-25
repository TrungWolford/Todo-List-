namespace GUI.Panel
{
    partial class TaskDetails
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
            pnl_taskDetail = new FlowLayoutPanel();
            pnl_detailTop = new FlowLayoutPanel();
            pnl_detailTitle = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txt_detailTitle = new TextBox();
            lbl_iconImportant = new Label();
            pnl_detailDuedate = new FlowLayoutPanel();
            label1 = new Label();
            lbl_detailDueDate = new Label();
            pnl_detailMiddle = new FlowLayoutPanel();
            pnl_detailAddFile = new FlowLayoutPanel();
            pnl_detailAddFile_Title = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            pnl_FileItems = new FlowLayoutPanel();
            panel4 = new System.Windows.Forms.Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel2 = new System.Windows.Forms.Panel();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel3 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            pnl_detailDescription = new FlowLayoutPanel();
            label19 = new Label();
            txt_detailDescription = new TextBox();
            pnl_detailBottom = new FlowLayoutPanel();
            pnl_detailCloseBtn = new FlowLayoutPanel();
            label20 = new Label();
            label21 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnl_detailCreatedDate = new FlowLayoutPanel();
            label23 = new Label();
            lbl_detailCreatedDate = new Label();
            pnl_detailDeleteBtn = new FlowLayoutPanel();
            label24 = new Label();
            label25 = new Label();
            pnl_taskDetail.SuspendLayout();
            pnl_detailTop.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            pnl_detailDuedate.SuspendLayout();
            pnl_detailMiddle.SuspendLayout();
            pnl_detailAddFile.SuspendLayout();
            pnl_detailAddFile_Title.SuspendLayout();
            pnl_FileItems.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            pnl_detailDescription.SuspendLayout();
            pnl_detailBottom.SuspendLayout();
            pnl_detailCloseBtn.SuspendLayout();
            pnl_detailCreatedDate.SuspendLayout();
            pnl_detailDeleteBtn.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_taskDetail
            // 
            pnl_taskDetail.BackColor = Color.White;
            pnl_taskDetail.Controls.Add(pnl_detailTop);
            pnl_taskDetail.Controls.Add(pnl_detailMiddle);
            pnl_taskDetail.Controls.Add(pnl_detailBottom);
            pnl_taskDetail.Location = new Point(12, 12);
            pnl_taskDetail.Name = "pnl_taskDetail";
            pnl_taskDetail.Size = new Size(560, 687);
            pnl_taskDetail.TabIndex = 1;
            // 
            // pnl_detailTop
            // 
            pnl_detailTop.BackColor = Color.White;
            pnl_detailTop.Controls.Add(pnl_detailTitle);
            pnl_detailTop.Controls.Add(flowLayoutPanel2);
            pnl_detailTop.Controls.Add(pnl_detailDuedate);
            pnl_detailTop.Location = new Point(0, 0);
            pnl_detailTop.Margin = new Padding(0);
            pnl_detailTop.Name = "pnl_detailTop";
            pnl_detailTop.Size = new Size(560, 137);
            pnl_detailTop.TabIndex = 7;
            // 
            // pnl_detailTitle
            // 
            pnl_detailTitle.AutoSize = true;
            pnl_detailTitle.BackColor = Color.White;
            pnl_detailTitle.Location = new Point(0, 0);
            pnl_detailTitle.Margin = new Padding(0);
            pnl_detailTitle.Name = "pnl_detailTitle";
            pnl_detailTitle.Size = new Size(0, 0);
            pnl_detailTitle.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(txt_detailTitle);
            flowLayoutPanel2.Controls.Add(lbl_iconImportant);
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(560, 40);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // txt_detailTitle
            // 
            txt_detailTitle.BackColor = Color.White;
            txt_detailTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailTitle.Location = new Point(0, 0);
            txt_detailTitle.Margin = new Padding(0);
            txt_detailTitle.MaxLength = 50;
            txt_detailTitle.Name = "txt_detailTitle";
            txt_detailTitle.Size = new Size(509, 39);
            txt_detailTitle.TabIndex = 8;
            txt_detailTitle.Text = "Task's Title";
            // 
            // lbl_iconImportant
            // 
            lbl_iconImportant.Image = Properties.Resources.star;
            lbl_iconImportant.Location = new Point(509, 0);
            lbl_iconImportant.Margin = new Padding(0);
            lbl_iconImportant.Name = "lbl_iconImportant";
            lbl_iconImportant.Size = new Size(47, 40);
            lbl_iconImportant.TabIndex = 9;
            // 
            // pnl_detailDuedate
            // 
            pnl_detailDuedate.BackColor = Color.White;
            pnl_detailDuedate.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailDuedate.Controls.Add(label1);
            pnl_detailDuedate.Controls.Add(lbl_detailDueDate);
            pnl_detailDuedate.Location = new Point(0, 40);
            pnl_detailDuedate.Margin = new Padding(0);
            pnl_detailDuedate.Name = "pnl_detailDuedate";
            pnl_detailDuedate.Size = new Size(560, 40);
            pnl_detailDuedate.TabIndex = 4;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.calendar;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(42, 40);
            label1.TabIndex = 5;
            // 
            // lbl_detailDueDate
            // 
            lbl_detailDueDate.BackColor = Color.White;
            lbl_detailDueDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_detailDueDate.Location = new Point(42, 0);
            lbl_detailDueDate.Margin = new Padding(0);
            lbl_detailDueDate.Name = "lbl_detailDueDate";
            lbl_detailDueDate.Size = new Size(514, 40);
            lbl_detailDueDate.TabIndex = 4;
            lbl_detailDueDate.Text = "10/10/2024";
            lbl_detailDueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_detailMiddle
            // 
            pnl_detailMiddle.BackColor = Color.White;
            pnl_detailMiddle.Controls.Add(pnl_detailAddFile);
            pnl_detailMiddle.Controls.Add(pnl_detailDescription);
            pnl_detailMiddle.Location = new Point(0, 137);
            pnl_detailMiddle.Margin = new Padding(0);
            pnl_detailMiddle.Name = "pnl_detailMiddle";
            pnl_detailMiddle.Size = new Size(560, 506);
            pnl_detailMiddle.TabIndex = 6;
            // 
            // pnl_detailAddFile
            // 
            pnl_detailAddFile.Controls.Add(pnl_detailAddFile_Title);
            pnl_detailAddFile.Controls.Add(pnl_FileItems);
            pnl_detailAddFile.Location = new Point(0, 0);
            pnl_detailAddFile.Margin = new Padding(0);
            pnl_detailAddFile.Name = "pnl_detailAddFile";
            pnl_detailAddFile.Size = new Size(560, 226);
            pnl_detailAddFile.TabIndex = 13;
            // 
            // pnl_detailAddFile_Title
            // 
            pnl_detailAddFile_Title.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailAddFile_Title.Controls.Add(label2);
            pnl_detailAddFile_Title.Controls.Add(label3);
            pnl_detailAddFile_Title.Location = new Point(0, 0);
            pnl_detailAddFile_Title.Margin = new Padding(0);
            pnl_detailAddFile_Title.Name = "pnl_detailAddFile_Title";
            pnl_detailAddFile_Title.Size = new Size(560, 48);
            pnl_detailAddFile_Title.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Image = Properties.Resources.sort2;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(42, 40);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(508, 40);
            label3.TabIndex = 4;
            label3.Text = "Add file";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_FileItems
            // 
            pnl_FileItems.AutoScroll = true;
            pnl_FileItems.Controls.Add(panel4);
            pnl_FileItems.Controls.Add(panel2);
            pnl_FileItems.Controls.Add(panel3);
            pnl_FileItems.Location = new Point(0, 48);
            pnl_FileItems.Margin = new Padding(0);
            pnl_FileItems.Name = "pnl_FileItems";
            pnl_FileItems.Size = new Size(560, 171);
            pnl_FileItems.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(560, 40);
            panel4.TabIndex = 15;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Image = Properties.Resources.task;
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(52, 40);
            label10.TabIndex = 13;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(52, 0);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(453, 40);
            label11.TabIndex = 12;
            label11.Text = "CoDau8Tuoi.pdf";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Location = new Point(505, 0);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(55, 40);
            label12.TabIndex = 11;
            label12.Text = "X";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 40);
            panel2.TabIndex = 12;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Image = Properties.Resources.task;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(52, 40);
            label7.TabIndex = 13;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(52, 0);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(453, 40);
            label8.TabIndex = 12;
            label8.Text = "CoDau8Tuoi.pdf";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(505, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(55, 40);
            label6.TabIndex = 11;
            label6.Text = "X";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(0, 80);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 120);
            panel3.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label15);
            panel5.Location = new Point(0, 40);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(560, 80);
            panel5.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label18);
            panel6.Location = new Point(0, 40);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(560, 40);
            panel6.TabIndex = 15;
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Image = Properties.Resources.task;
            label16.Location = new Point(0, 0);
            label16.Margin = new Padding(0);
            label16.Name = "label16";
            label16.Size = new Size(52, 40);
            label16.TabIndex = 13;
            // 
            // label17
            // 
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(52, 0);
            label17.Margin = new Padding(0);
            label17.Name = "label17";
            label17.Size = new Size(453, 40);
            label17.TabIndex = 12;
            label17.Text = "CoDau8Tuoi.pdf";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.Location = new Point(505, 0);
            label18.Margin = new Padding(0);
            label18.Name = "label18";
            label18.Size = new Size(55, 40);
            label18.TabIndex = 11;
            label18.Text = "X";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Image = Properties.Resources.task;
            label13.Location = new Point(0, 0);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.Size = new Size(52, 40);
            label13.TabIndex = 13;
            // 
            // label14
            // 
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(52, 0);
            label14.Margin = new Padding(0);
            label14.Name = "label14";
            label14.Size = new Size(453, 40);
            label14.TabIndex = 12;
            label14.Text = "CoDau8Tuoi.pdf";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.BackColor = Color.White;
            label15.Location = new Point(505, 0);
            label15.Margin = new Padding(0);
            label15.Name = "label15";
            label15.Size = new Size(55, 40);
            label15.TabIndex = 11;
            label15.Text = "X";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Image = Properties.Resources.task;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(52, 40);
            label4.TabIndex = 13;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(453, 40);
            label5.TabIndex = 12;
            label5.Text = "CoDau8Tuoi.pdf";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Location = new Point(505, 0);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(55, 40);
            label9.TabIndex = 11;
            label9.Text = "X";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_detailDescription
            // 
            pnl_detailDescription.AutoSize = true;
            pnl_detailDescription.Controls.Add(label19);
            pnl_detailDescription.Controls.Add(txt_detailDescription);
            pnl_detailDescription.Location = new Point(0, 226);
            pnl_detailDescription.Margin = new Padding(0);
            pnl_detailDescription.Name = "pnl_detailDescription";
            pnl_detailDescription.Size = new Size(560, 162);
            pnl_detailDescription.TabIndex = 14;
            // 
            // label19
            // 
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(0, 0);
            label19.Margin = new Padding(0);
            label19.Name = "label19";
            label19.Size = new Size(560, 40);
            label19.TabIndex = 3;
            label19.Text = "Decription";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_detailDescription
            // 
            txt_detailDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_detailDescription.Location = new Point(0, 40);
            txt_detailDescription.Margin = new Padding(0);
            txt_detailDescription.MaxLength = 255;
            txt_detailDescription.Multiline = true;
            txt_detailDescription.Name = "txt_detailDescription";
            txt_detailDescription.ScrollBars = ScrollBars.Vertical;
            txt_detailDescription.Size = new Size(560, 122);
            txt_detailDescription.TabIndex = 14;
            txt_detailDescription.Text = "Test Descriptiondsadasdsadasdsaaaaaaaaaaadsdasdasdasdasdasdsadsadasdaadasdasdsa";
            // 
            // pnl_detailBottom
            // 
            pnl_detailBottom.Controls.Add(pnl_detailCloseBtn);
            pnl_detailBottom.Controls.Add(flowLayoutPanel1);
            pnl_detailBottom.Controls.Add(pnl_detailCreatedDate);
            pnl_detailBottom.Controls.Add(pnl_detailDeleteBtn);
            pnl_detailBottom.Location = new Point(0, 643);
            pnl_detailBottom.Margin = new Padding(0);
            pnl_detailBottom.Name = "pnl_detailBottom";
            pnl_detailBottom.Size = new Size(560, 44);
            pnl_detailBottom.TabIndex = 8;
            // 
            // pnl_detailCloseBtn
            // 
            pnl_detailCloseBtn.AutoSize = true;
            pnl_detailCloseBtn.BackColor = Color.White;
            pnl_detailCloseBtn.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailCloseBtn.Controls.Add(label20);
            pnl_detailCloseBtn.Controls.Add(label21);
            pnl_detailCloseBtn.Location = new Point(0, 0);
            pnl_detailCloseBtn.Margin = new Padding(0);
            pnl_detailCloseBtn.Name = "pnl_detailCloseBtn";
            pnl_detailCloseBtn.Size = new Size(118, 42);
            pnl_detailCloseBtn.TabIndex = 6;
            // 
            // label20
            // 
            label20.Image = Properties.Resources.calendar;
            label20.Location = new Point(0, 0);
            label20.Margin = new Padding(0);
            label20.Name = "label20";
            label20.Size = new Size(52, 40);
            label20.TabIndex = 5;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(52, 0);
            label21.Margin = new Padding(0);
            label21.Name = "label21";
            label21.Size = new Size(64, 40);
            label21.TabIndex = 4;
            label21.Text = "Close";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(118, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // pnl_detailCreatedDate
            // 
            pnl_detailCreatedDate.Controls.Add(label23);
            pnl_detailCreatedDate.Controls.Add(lbl_detailCreatedDate);
            pnl_detailCreatedDate.Location = new Point(118, 0);
            pnl_detailCreatedDate.Margin = new Padding(0);
            pnl_detailCreatedDate.Name = "pnl_detailCreatedDate";
            pnl_detailCreatedDate.Size = new Size(303, 40);
            pnl_detailCreatedDate.TabIndex = 17;
            // 
            // label23
            // 
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(0, 0);
            label23.Margin = new Padding(0);
            label23.Name = "label23";
            label23.Size = new Size(123, 40);
            label23.TabIndex = 5;
            label23.Text = "Created on: ";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_detailCreatedDate
            // 
            lbl_detailCreatedDate.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_detailCreatedDate.Location = new Point(123, 0);
            lbl_detailCreatedDate.Margin = new Padding(0);
            lbl_detailCreatedDate.Name = "lbl_detailCreatedDate";
            lbl_detailCreatedDate.Size = new Size(180, 40);
            lbl_detailCreatedDate.TabIndex = 6;
            lbl_detailCreatedDate.Text = "Friday, November 15";
            lbl_detailCreatedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_detailDeleteBtn
            // 
            pnl_detailDeleteBtn.AutoSize = true;
            pnl_detailDeleteBtn.BackColor = Color.White;
            pnl_detailDeleteBtn.BorderStyle = BorderStyle.FixedSingle;
            pnl_detailDeleteBtn.Controls.Add(label24);
            pnl_detailDeleteBtn.Controls.Add(label25);
            pnl_detailDeleteBtn.Location = new Point(421, 0);
            pnl_detailDeleteBtn.Margin = new Padding(0);
            pnl_detailDeleteBtn.Name = "pnl_detailDeleteBtn";
            pnl_detailDeleteBtn.Size = new Size(137, 42);
            pnl_detailDeleteBtn.TabIndex = 8;
            // 
            // label24
            // 
            label24.Image = Properties.Resources.calendar;
            label24.Location = new Point(0, 0);
            label24.Margin = new Padding(0);
            label24.Name = "label24";
            label24.Size = new Size(52, 40);
            label24.TabIndex = 5;
            // 
            // label25
            // 
            label25.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(52, 0);
            label25.Margin = new Padding(0);
            label25.Name = "label25";
            label25.Size = new Size(83, 40);
            label25.TabIndex = 4;
            label25.Text = "Delete";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TaskDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 711);
            Controls.Add(pnl_taskDetail);
            Name = "TaskDetails";
            Text = "TaskDetails";
            pnl_taskDetail.ResumeLayout(false);
            pnl_detailTop.ResumeLayout(false);
            pnl_detailTop.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            pnl_detailDuedate.ResumeLayout(false);
            pnl_detailMiddle.ResumeLayout(false);
            pnl_detailMiddle.PerformLayout();
            pnl_detailAddFile.ResumeLayout(false);
            pnl_detailAddFile_Title.ResumeLayout(false);
            pnl_FileItems.ResumeLayout(false);
            pnl_FileItems.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            pnl_detailDescription.ResumeLayout(false);
            pnl_detailDescription.PerformLayout();
            pnl_detailBottom.ResumeLayout(false);
            pnl_detailBottom.PerformLayout();
            pnl_detailCloseBtn.ResumeLayout(false);
            pnl_detailCreatedDate.ResumeLayout(false);
            pnl_detailDeleteBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnl_taskDetail;
        private Label lbl_detailTitle;
        private FlowLayoutPanel pnl_detailDuedate;
        private Label label1;
        private Label lbl_detailDueDate;
        private FlowLayoutPanel pnl_detailTitle;
        private FlowLayoutPanel pnl_detailMiddle;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel pnl_detailTop;
        private FlowLayoutPanel pnl_FileItems;
        private FlowLayoutPanel pnl_detailAddFile;
        private FlowLayoutPanel pnl_detailAddFile_Title;
        private TextBox txt_detailDescription;
        private System.Windows.Forms.Panel panel2;
        private Label label7;
        private Label label8;
        private Label label6;
        private System.Windows.Forms.Panel panel4;
        private Label label10;
        private Label label11;
        private Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label4;
        private Label label5;
        private Label label9;
        private FlowLayoutPanel pnl_detailDescription;
        private Label label19;
        private FlowLayoutPanel pnl_detailBottom;
        private FlowLayoutPanel pnl_detailCloseBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label20;
        private Label label21;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel pnl_detailDeleteBtn;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel pnl_detailCreatedDate;
        private Label label23;
        private Label lbl_detailCreatedDate;
        private Label label24;
        private Label label25;
        private TextBox txt_detailTitle;
        private Label lbl_iconImportant;
    }
}