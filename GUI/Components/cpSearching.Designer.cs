﻿namespace GUI.Components
{
    partial class cpSearching
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
            pnlSearching = new Label();
            textBox1 = new TextBox();
            pnlSearching.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSearching
            // 
            pnlSearching.Controls.Add(textBox1);
            pnlSearching.Location = new Point(16, 16);
            pnlSearching.Name = "pnlSearching";
            pnlSearching.Size = new Size(550, 50);
            pnlSearching.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 27);
            textBox1.TabIndex = 0;
            // 
            // cpSearching
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSearching);
            Name = "cpSearching";
            Size = new Size(589, 82);
            pnlSearching.ResumeLayout(false);
            pnlSearching.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label pnlSearching;
        private TextBox textBox1;
    }
}
