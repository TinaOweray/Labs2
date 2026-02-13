namespace FunctionCalculation
{
    partial class IntervalForm
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
            label1 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Границы интервала";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(29, 83);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(150, 31);
            textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(228, 83);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(150, 31);
            textBoxB.TabIndex = 2;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(29, 152);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 62);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Передать данные";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(266, 152);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 58);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отменить передачу";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // IntervalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 247);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IntervalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Введите значения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttonOk;
        private Button buttonCancel;
    }
}