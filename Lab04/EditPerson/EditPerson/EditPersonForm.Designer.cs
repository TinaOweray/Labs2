namespace EditPerson
{
    partial class EditPersonForm
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
            lblfirstName = new Label();
            lbllastName = new Label();
            lblAge = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // lblfirstName
            // 
            lblfirstName.AutoSize = true;
            lblfirstName.Location = new Point(40, 39);
            lblfirstName.Name = "lblfirstName";
            lblfirstName.Size = new Size(47, 25);
            lblfirstName.TabIndex = 0;
            lblfirstName.Text = "Имя";
            // 
            // lbllastName
            // 
            lbllastName.AutoSize = true;
            lbllastName.Location = new Point(40, 93);
            lbllastName.Name = "lbllastName";
            lbllastName.Size = new Size(85, 25);
            lbllastName.TabIndex = 1;
            lbllastName.Text = "Фамилия";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(40, 148);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(76, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "Возраст";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(183, 39);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(150, 31);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(183, 93);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(150, 31);
            lastNameTextBox.TabIndex = 2;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(183, 142);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(80, 31);
            ageNumericUpDown.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(44, 190);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(274, 190);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // EditPersonForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 236);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(ageNumericUpDown);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lblAge);
            Controls.Add(lbllastName);
            Controls.Add(lblfirstName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPersonForm";
            ShowInTaskbar = false;
            Text = "Редактирование сотрудника";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblfirstName;
        private Label lbllastName;
        private Label lblAge;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private NumericUpDown ageNumericUpDown;
        private Button buttonSave;
        private Button buttonCancel;
    }
}