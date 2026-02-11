namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox = new ListBox();
            btnSend = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Items.AddRange(new object[] { "тут какой-то текст" });
            listBox.Location = new Point(28, 197);
            listBox.Name = "listBox";
            listBox.Size = new Size(200, 179);
            listBox.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Location = new Point(277, 197);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(176, 31);
            btnSend.TabIndex = 1;
            btnSend.Text = "Отправить";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 55);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 4;
            label1.Text = "Введите данные";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(238, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 31);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 444);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(listBox);
            MinimumSize = new Size(450, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Резиновая форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Button btnSend;
        private Label label1;
        private TextBox textBox1;
    }
}
