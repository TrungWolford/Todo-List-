namespace GUI.Components
{
    partial class TaskStep
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
            txt_StepName = new TextBox();
            lbl_StepRemoveBtn = new Label();
            check_Done = new CheckBox();
            SuspendLayout();
            // 
            // txt_StepName
            // 
            txt_StepName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_StepName.Location = new Point(36, 0);
            txt_StepName.Margin = new Padding(0);
            txt_StepName.MaxLength = 50;
            txt_StepName.Multiline = true;
            txt_StepName.Name = "txt_StepName";
            txt_StepName.PlaceholderText = "Step name";
            txt_StepName.Size = new Size(469, 35);
            txt_StepName.TabIndex = 0;
            txt_StepName.WordWrap = false;
            txt_StepName.TextChanged += txt_StepName_TextChanged;
            // 
            // lbl_StepRemoveBtn
            // 
            lbl_StepRemoveBtn.BackColor = Color.Tomato;
            lbl_StepRemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_StepRemoveBtn.ForeColor = Color.Black;
            lbl_StepRemoveBtn.Location = new Point(505, 0);
            lbl_StepRemoveBtn.Margin = new Padding(0);
            lbl_StepRemoveBtn.Name = "lbl_StepRemoveBtn";
            lbl_StepRemoveBtn.Size = new Size(35, 35);
            lbl_StepRemoveBtn.TabIndex = 15;
            lbl_StepRemoveBtn.Text = "X";
            lbl_StepRemoveBtn.TextAlign = ContentAlignment.MiddleCenter;
            lbl_StepRemoveBtn.Click += lbl_StepRemoveBtn_Click;
            // 
            // check_Done
            // 
            check_Done.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_Done.Location = new Point(13, 5);
            check_Done.Name = "check_Done";
            check_Done.Size = new Size(16, 28);
            check_Done.TabIndex = 16;
            check_Done.UseVisualStyleBackColor = true;
            check_Done.CheckedChanged += check_Done_CheckedChanged;
            // 
            // TaskStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(check_Done);
            Controls.Add(lbl_StepRemoveBtn);
            Controls.Add(txt_StepName);
            Margin = new Padding(0);
            Name = "TaskStep";
            Size = new Size(540, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_StepName;
        private Label lbl_StepRemoveBtn;
        private CheckBox check_Done;
    }
}
