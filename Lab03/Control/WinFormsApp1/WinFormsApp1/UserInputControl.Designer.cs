namespace WinFormsApp1
{
    partial class UserInputControl
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
            components = new System.ComponentModel.Container();
            labelFIO = new Label();
            labelAge = new Label();
            labelEmail = new Label();
            tbFullName = new TextBox();
            tbEmail = new TextBox();
            tbAge = new TextBox();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Location = new Point(13, 17);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(52, 25);
            labelFIO.TabIndex = 0;
            labelFIO.Text = "ФИО";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(13, 63);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(76, 25);
            labelAge.TabIndex = 1;
            labelAge.Text = "Возраст";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(13, 110);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(100, 13);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(236, 31);
            tbFullName.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(101, 109);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(235, 31);
            tbEmail.TabIndex = 3;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(101, 64);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(48, 31);
            tbAge.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(15, 171);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UserInputControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(tbAge);
            Controls.Add(tbEmail);
            Controls.Add(tbFullName);
            Controls.Add(labelEmail);
            Controls.Add(labelAge);
            Controls.Add(labelFIO);
            Name = "UserInputControl";
            Size = new Size(353, 217);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFIO;
        private Label labelAge;
        private Label labelEmail;
        private TextBox tbFullName;
        private TextBox tbEmail;
        private TextBox tbAge;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}
