namespace WinFormsApp1
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
            userInputControl1 = new UserInputControl();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // userInputControl1
            // 
            userInputControl1.Location = new Point(1, -1);
            userInputControl1.Name = "userInputControl1";
            userInputControl1.Size = new Size(500, 214);
            userInputControl1.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.BorderStyle = BorderStyle.FixedSingle;
            lblInfo.Location = new Point(9, 228);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(478, 79);
            lblInfo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 316);
            Controls.Add(lblInfo);
            Controls.Add(userInputControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Регистрация";
            ResumeLayout(false);
        }

        #endregion

        private UserInputControl userInputControl1;
        private Label lblInfo;
    }
}
