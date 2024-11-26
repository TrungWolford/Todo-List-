namespace GUI.Components
{
    partial class AttachmentItem
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
            lbl_FileImg = new Label();
            lbl_FileName = new Label();
            lbl_FileRemoveBtn = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_FileImg
            // 
            lbl_FileImg.BackColor = Color.White;
            lbl_FileImg.Image = Properties.Resources.task;
            lbl_FileImg.Location = new Point(0, 0);
            lbl_FileImg.Margin = new Padding(0);
            lbl_FileImg.Name = "lbl_FileImg";
            lbl_FileImg.Size = new Size(52, 40);
            lbl_FileImg.TabIndex = 13;
            // 
            // lbl_FileName
            // 
            lbl_FileName.BackColor = Color.White;
            lbl_FileName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FileName.Location = new Point(52, 0);
            lbl_FileName.Margin = new Padding(0);
            lbl_FileName.Name = "lbl_FileName";
            lbl_FileName.Size = new Size(453, 40);
            lbl_FileName.TabIndex = 12;
            lbl_FileName.Text = "CoDau8Tuoi.pdf";
            lbl_FileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_FileRemoveBtn
            // 
            lbl_FileRemoveBtn.BackColor = Color.White;
            lbl_FileRemoveBtn.Location = new Point(505, 0);
            lbl_FileRemoveBtn.Margin = new Padding(0);
            lbl_FileRemoveBtn.Name = "lbl_FileRemoveBtn";
            lbl_FileRemoveBtn.Size = new Size(55, 40);
            lbl_FileRemoveBtn.TabIndex = 14;
            lbl_FileRemoveBtn.Text = "X";
            lbl_FileRemoveBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl_FileImg);
            flowLayoutPanel1.Controls.Add(lbl_FileName);
            flowLayoutPanel1.Controls.Add(lbl_FileRemoveBtn);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0, 0, 0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(560, 40);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // AttachmentItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(560, 40);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttachmentItem";
            Text = "AttachmentItem";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_FileImg;
        private Label lbl_FileName;
        private Label lbl_FileRemoveBtn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}