namespace GUI.Panel
{
    partial class ChatBotForm
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
            txtOutput = new TextBox();
            btnQuestion1 = new Button();
            btnQuestion2 = new Button();
            btnQuestion3 = new Button();
            txtInput = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(54, 68);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(823, 281);
            txtOutput.TabIndex = 0;
            // 
            // btnQuestion1
            // 
            btnQuestion1.Location = new Point(360, 377);
            btnQuestion1.Name = "btnQuestion1";
            btnQuestion1.Size = new Size(184, 29);
            btnQuestion1.TabIndex = 1;
            btnQuestion1.Text = "button1";
            btnQuestion1.UseVisualStyleBackColor = true;
            // 
            // btnQuestion2
            // 
            btnQuestion2.Location = new Point(360, 428);
            btnQuestion2.Name = "btnQuestion2";
            btnQuestion2.Size = new Size(184, 29);
            btnQuestion2.TabIndex = 2;
            btnQuestion2.Text = "button2";
            btnQuestion2.UseVisualStyleBackColor = true;
            // 
            // btnQuestion3
            // 
            btnQuestion3.Location = new Point(360, 478);
            btnQuestion3.Name = "btnQuestion3";
            btnQuestion3.Size = new Size(184, 29);
            btnQuestion3.TabIndex = 3;
            btnQuestion3.Text = "button3";
            btnQuestion3.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(54, 553);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(709, 27);
            txtInput.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(783, 551);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 5;
            btnSend.Text = "button4";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // ChatBotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 616);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(btnQuestion3);
            Controls.Add(btnQuestion2);
            Controls.Add(btnQuestion1);
            Controls.Add(txtOutput);
            Name = "ChatBotForm";
            Text = "ChatBotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Button btnQuestion1;
        private Button btnQuestion2;
        private Button btnQuestion3;
        private TextBox txtInput;
        private Button btnSend;
    }
}