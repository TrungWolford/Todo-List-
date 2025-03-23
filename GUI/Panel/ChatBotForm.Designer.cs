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
            btnQuestion1 = new Button();
            btnQuestion2 = new Button();
            btnQuestion3 = new Button();
            txtInput = new TextBox();
            btnSend = new Button();
            txtOutput = new RichTextBox();
            SuspendLayout();
            // 
            // btnQuestion1
            // 
            btnQuestion1.Location = new Point(217, 377);
            btnQuestion1.Name = "btnQuestion1";
            btnQuestion1.Size = new Size(502, 29);
            btnQuestion1.TabIndex = 1;
            btnQuestion1.Text = "Làm sao để duy trì thói quen sử dụng To-Do List hàng ngày?";
            btnQuestion1.UseVisualStyleBackColor = true;
            btnQuestion1.Click += btnQuestion1_Click;
            // 
            // btnQuestion2
            // 
            btnQuestion2.Location = new Point(141, 432);
            btnQuestion2.Name = "btnQuestion2";
            btnQuestion2.Size = new Size(653, 29);
            btnQuestion2.TabIndex = 2;
            btnQuestion2.Text = "Có phương pháp nào giúp hoàn thành To-Do List mà không bị stress?";
            btnQuestion2.UseVisualStyleBackColor = true;
            btnQuestion2.Click += btnQuestion2_Click;
            // 
            // btnQuestion3
            // 
            btnQuestion3.Location = new Point(248, 493);
            btnQuestion3.Name = "btnQuestion3";
            btnQuestion3.Size = new Size(422, 29);
            btnQuestion3.TabIndex = 3;
            btnQuestion3.Text = "Làm sao để đánh giá hiệu quả của To-Do List?";
            btnQuestion3.UseVisualStyleBackColor = true;
            btnQuestion3.Click += btnQuestion3_Click;
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
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(70, 66);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(807, 287);
            txtOutput.TabIndex = 6;
            txtOutput.Text = "";
            // 
            // ChatBotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 616);
            Controls.Add(txtOutput);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(btnQuestion3);
            Controls.Add(btnQuestion2);
            Controls.Add(btnQuestion1);
            Name = "ChatBotForm";
            Text = "ChatBotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnQuestion1;
        private Button btnQuestion2;
        private Button btnQuestion3;
        private TextBox txtInput;
        private Button btnSend;
        private RichTextBox txtOutput;
    }
}