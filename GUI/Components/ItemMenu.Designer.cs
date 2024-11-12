namespace GUI.Components
{
    partial class ItemMenu
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
        private void InitializeComponent(string pathIcon, string text)
        {
            pnl_itemMenu = new System.Windows.Forms.Panel();
            lbl_itemMenu = new Label();
            pnl_itemMenu.SuspendLayout();
            SuspendLayout();

            // 
            // pnl_itemMenu
            // 
            pnl_itemMenu.BackColor = Color.White;
            pnl_itemMenu.Controls.Add(lbl_itemMenu);
            pnl_itemMenu.Location = new Point(3, 1);
            pnl_itemMenu.Name = "pnl_itemMenu";
            pnl_itemMenu.Size = new Size(206, 45);
            pnl_itemMenu.TabIndex = 0;

            // 
            // lbl_itemMenu
            // 
            lbl_itemMenu.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_itemMenu.Location = new Point(0, 3);
            lbl_itemMenu.Name = "lbl_itemMenu";
            lbl_itemMenu.Size = new Size(208, 42);
            lbl_itemMenu.TabIndex = 0;
            lbl_itemMenu.Text = text; // Set the text passed in the constructor
            lbl_itemMenu.TextAlign = ContentAlignment.MiddleRight;

            // Load the image from pathIcon and assign it to lbl_itemMenu.Image
            if (!string.IsNullOrEmpty(pathIcon) && System.IO.File.Exists(pathIcon))
            {
                lbl_itemMenu.Image = Image.FromFile(pathIcon);
            }
            else
            {
                lbl_itemMenu.Image = null; // Set to null if the icon path is invalid
            }

            // 
            // ItemMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_itemMenu);
            Cursor = Cursors.Hand;
            Name = "ItemMenu";
            Size = new Size(213, 50);
            MouseHover += ItemMenu_MouseHover;

            pnl_itemMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_itemMenu;
        private Label lbl_itemMenu;
    }
}
