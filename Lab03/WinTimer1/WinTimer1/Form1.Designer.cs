namespace WinTimer1
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
            userControlTimer1 = new UserControlTimer();
            buttonFix = new Button();
            userControl11 = new WinFormsControlLibraryTimer.UserControl1();
            bntPause = new Button();
            SuspendLayout();
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(53, 36);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(127, 59);
            userControlTimer1.TabIndex = 0;
            userControlTimer1.TimeEnabled = true;
            // 
            // buttonFix
            // 
            buttonFix.Location = new Point(186, 49);
            buttonFix.Name = "buttonFix";
            buttonFix.Size = new Size(153, 34);
            buttonFix.TabIndex = 1;
            buttonFix.Text = "Пауза";
            buttonFix.UseVisualStyleBackColor = true;
            buttonFix.Click += buttonFix_Click;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(42, 152);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(127, 83);
            userControl11.TabIndex = 2;
            userControl11.TimeEnabled = true;
            // 
            // bntPause
            // 
            bntPause.Location = new Point(186, 188);
            bntPause.Name = "bntPause";
            bntPause.Size = new Size(163, 34);
            bntPause.TabIndex = 3;
            bntPause.Text = "Пауза DDl";
            bntPause.UseVisualStyleBackColor = true;
            bntPause.Click += bntPause_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 295);
            Controls.Add(bntPause);
            Controls.Add(userControl11);
            Controls.Add(buttonFix);
            Controls.Add(userControlTimer1);
            Name = "Form1";
            Text = "Tiik-tak";
            ResumeLayout(false);
        }

        #endregion

        private UserControlTimer userControlTimer1;
        private Button buttonFix;
        private WinFormsControlLibraryTimer.UserControl1 userControl11;
        private Button bntPause;
    }
}
