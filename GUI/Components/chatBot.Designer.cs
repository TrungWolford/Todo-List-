namespace GUI.Components
{
    partial class chatBot
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
            iconAI = new PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)iconAI).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconAI
            // 
            iconAI.Dock = DockStyle.Fill;
            iconAI.Image = Properties.Resources.ai_512px;
            iconAI.Location = new Point(0, 0);
            iconAI.Name = "iconAI";
            iconAI.Size = new Size(96, 91);
            iconAI.SizeMode = PictureBoxSizeMode.Zoom;
            iconAI.TabIndex = 1;
            iconAI.TabStop = false;
            iconAI.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconAI);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 91);
            panel1.TabIndex = 2;
            // 
            // chatBot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "chatBot";
            Size = new Size(96, 91);
            ((System.ComponentModel.ISupportInitialize)iconAI).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconAI;
        private System.Windows.Forms.Panel panel1;
    }
}
