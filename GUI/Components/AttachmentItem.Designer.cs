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
            lbl_FileName = new Label();
            lbl_FileRemoveBtn = new Label();
            pnl_attachItem = new System.Windows.Forms.Panel();
            pnl_attachItem.SuspendLayout();
            SuspendLayout();
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
            // pnl_attachItem
            // 
            pnl_attachItem.BorderStyle = BorderStyle.FixedSingle;
            pnl_attachItem.Controls.Add(lbl_FileName);
            pnl_attachItem.Controls.Add(lbl_FileRemoveBtn);
            pnl_attachItem.Location = new Point(0, 0);
            pnl_attachItem.Margin = new Padding(0, 0, 0, 0);
            pnl_attachItem.Name = "pnl_attachItem";
            pnl_attachItem.Size = new Size(540, 40);
            pnl_attachItem.TabIndex = 16;
            // 
            // AttachmentItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(540, 40);
            Controls.Add(pnl_attachItem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttachmentItem";
            Text = "AttachmentItem";
            pnl_attachItem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_FileName;
        private Label lbl_FileRemoveBtn;
        private System.Windows.Forms.Panel pnl_attachItem;
    }
}