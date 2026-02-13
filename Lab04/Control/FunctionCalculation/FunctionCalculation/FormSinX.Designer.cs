namespace FunctionCalculation
{
    partial class FormSinX
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
            label1 = new Label();
            labelInterval = new Label();
            richTextBoxResult = new RichTextBox();
            buttonSetInterval = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 27);
            label1.Name = "label1";
            label1.Size = new Size(327, 25);
            label1.TabIndex = 0;
            label1.Text = "Значения функции sin(x) на интервале:";
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Location = new Point(100, 75);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new Size(165, 25);
            labelInterval.TabIndex = 1;
            labelInterval.Text = "Интервал не задан";
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Location = new Point(94, 122);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(322, 248);
            richTextBoxResult.TabIndex = 2;
            richTextBoxResult.Text = "";
            // 
            // buttonSetInterval
            // 
            buttonSetInterval.Location = new Point(480, 122);
            buttonSetInterval.Name = "buttonSetInterval";
            buttonSetInterval.Size = new Size(118, 89);
            buttonSetInterval.TabIndex = 3;
            buttonSetInterval.Text = "Задать интервал";
            buttonSetInterval.UseVisualStyleBackColor = true;
            buttonSetInterval.Click += buttonSetInterval_Click;
            // 
            // FormSinX
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 414);
            Controls.Add(buttonSetInterval);
            Controls.Add(richTextBoxResult);
            Controls.Add(labelInterval);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSinX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sin(x)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelInterval;
        private RichTextBox richTextBoxResult;
        private Button buttonSetInterval;
    }
}
