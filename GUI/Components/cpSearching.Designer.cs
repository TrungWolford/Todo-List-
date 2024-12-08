namespace GUI.Components
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
            txt_search = new TextBox();
            pnlSearching.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSearching
            // 
            pnlSearching.Controls.Add(txt_search);
            pnlSearching.Location = new Point(16, 16);
            pnlSearching.Name = "pnlSearching";
            pnlSearching.Size = new Size(550, 50);
            pnlSearching.TabIndex = 0;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(0, 13);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(550, 27);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += txt_search_TextChanged;
            txt_search.Enter += txt_search_Enter;
            txt_search.Leave += txt_search_Leave;
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
        private TextBox txt_search;
    }
}
