namespace GUI.Components
{
    partial class AttachItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_attachItem = new System.Windows.Forms.Panel();
            lbl_FileName = new Label();
            lbl_FileRemoveBtn = new Label();
            lbl_FileDownloadBtn = new Label();
            pnl_attachItem.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_attachItem
            // 
            pnl_attachItem.BorderStyle = BorderStyle.FixedSingle;
            pnl_attachItem.Controls.Add(lbl_FileDownloadBtn);
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
            lbl_FileName.Size = new Size(460, 40);
            lbl_FileName.TabIndex = 12;
            lbl_FileName.Text = "CoDau8Tuoi.pdf";
            lbl_FileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_FileRemoveBtn
            // 
            lbl_FileRemoveBtn.BackColor = Color.Tomato;
            lbl_FileRemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_FileRemoveBtn.ForeColor = Color.Black;
            lbl_FileRemoveBtn.Location = new Point(500, 0);
            lbl_FileRemoveBtn.Margin = new Padding(0);
            lbl_FileRemoveBtn.Name = "lbl_FileRemoveBtn";
            lbl_FileRemoveBtn.Size = new Size(40, 40);
            lbl_FileRemoveBtn.TabIndex = 14;
            lbl_FileRemoveBtn.Text = "X";
            lbl_FileRemoveBtn.TextAlign = ContentAlignment.MiddleCenter;
            lbl_FileRemoveBtn.Click += lbl_FileRemoveBtn_Click;
            // 
            // lbl_FileDownloadBtn
            // 
            lbl_FileDownloadBtn.BackColor = Color.DodgerBlue;
            lbl_FileDownloadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_FileDownloadBtn.ForeColor = Color.White;
            lbl_FileDownloadBtn.Image = Properties.Resources.downloads;
            lbl_FileDownloadBtn.Location = new Point(460, -1);
            lbl_FileDownloadBtn.Margin = new Padding(0);
            lbl_FileDownloadBtn.Name = "lbl_FileDownloadBtn";
            lbl_FileDownloadBtn.Size = new Size(40, 40);
            lbl_FileDownloadBtn.TabIndex = 15;
            lbl_FileDownloadBtn.TextAlign = ContentAlignment.MiddleCenter;
            lbl_FileDownloadBtn.Click += lbl_FileDownloadBtn_Click;
            // 
            // AttachItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_attachItem);
            Margin = new Padding(0);
            Name = "AttachItem";
            Size = new Size(540, 40);
            pnl_attachItem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_attachItem;
        private Label lbl_FileName;
        private Label lbl_FileRemoveBtn;
        private Label lbl_FileDownloadBtn;
    }
}
