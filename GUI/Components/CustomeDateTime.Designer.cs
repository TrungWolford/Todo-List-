namespace GUI.Components
{
    partial class CustomeDateTime
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
            monthCalendar_Custome = new MonthCalendar();
            lbl_textCustome = new Label();
            txt_CustomeHour = new TextBox();
            txt_CustomeMinute = new TextBox();
            btn_CustomeDone = new Button();
            btn_CustomeClose = new Button();
            lbl_CustomeHourMinute = new Label();
            SuspendLayout();
            // 
            // monthCalendar_Custome
            // 
            monthCalendar_Custome.Location = new Point(0, 0);
            monthCalendar_Custome.Name = "monthCalendar_Custome";
            monthCalendar_Custome.TabIndex = 0;
            monthCalendar_Custome.DateSelected += monthCalendar_DateSelected;
            // 
            // lbl_textCustome
            // 
            lbl_textCustome.AutoSize = true;
            lbl_textCustome.Location = new Point(113, 216);
            lbl_textCustome.Name = "lbl_textCustome";
            lbl_textCustome.Size = new Size(12, 20);
            lbl_textCustome.TabIndex = 1;
            lbl_textCustome.Text = ":";
            // 
            // txt_CustomeHour
            // 
            txt_CustomeHour.Location = new Point(62, 216);
            txt_CustomeHour.Name = "txt_CustomeHour";
            txt_CustomeHour.Size = new Size(45, 27);
            txt_CustomeHour.TabIndex = 2;
            txt_CustomeHour.Text = "06";
            txt_CustomeHour.TextAlign = HorizontalAlignment.Center;
            txt_CustomeHour.TextChanged += txt_CustomeHour_TextChanged;
            // 
            // txt_CustomeMinute
            // 
            txt_CustomeMinute.Location = new Point(131, 216);
            txt_CustomeMinute.Name = "txt_CustomeMinute";
            txt_CustomeMinute.Size = new Size(45, 27);
            txt_CustomeMinute.TabIndex = 3;
            txt_CustomeMinute.Text = "00";
            txt_CustomeMinute.TextAlign = HorizontalAlignment.Center;
            txt_CustomeMinute.TextChanged += txt_CustomeMinute_TextChanged;
            // 
            // btn_CustomeDone
            // 
            btn_CustomeDone.Location = new Point(36, 307);
            btn_CustomeDone.Name = "btn_CustomeDone";
            btn_CustomeDone.Size = new Size(71, 40);
            btn_CustomeDone.TabIndex = 5;
            btn_CustomeDone.Text = "Done";
            btn_CustomeDone.UseVisualStyleBackColor = true;
            btn_CustomeDone.Click += btn_CustomeDone_Click;
            // 
            // btn_CustomeClose
            // 
            btn_CustomeClose.Location = new Point(145, 307);
            btn_CustomeClose.Name = "btn_CustomeClose";
            btn_CustomeClose.Size = new Size(71, 40);
            btn_CustomeClose.TabIndex = 6;
            btn_CustomeClose.Text = "Close";
            btn_CustomeClose.UseVisualStyleBackColor = true;
            btn_CustomeClose.Click += btn_CustomeClose_Click;
            // 
            // lbl_CustomeHourMinute
            // 
            lbl_CustomeHourMinute.BackColor = Color.White;
            lbl_CustomeHourMinute.Location = new Point(36, 265);
            lbl_CustomeHourMinute.Name = "lbl_CustomeHourMinute";
            lbl_CustomeHourMinute.Size = new Size(180, 26);
            lbl_CustomeHourMinute.TabIndex = 7;
            lbl_CustomeHourMinute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomeDateTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_CustomeHourMinute);
            Controls.Add(btn_CustomeClose);
            Controls.Add(btn_CustomeDone);
            Controls.Add(txt_CustomeMinute);
            Controls.Add(txt_CustomeHour);
            Controls.Add(lbl_textCustome);
            Controls.Add(monthCalendar_Custome);
            Name = "CustomeDateTime";
            Size = new Size(261, 392);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar_Custome;
        private Label lbl_textCustome;
        private TextBox txt_CustomeHour;
        private TextBox txt_CustomeMinute;
        private Button btn_CustomeDone;
        private Button btn_CustomeClose;
        private Label lbl_CustomeHourMinute;
    }
}
