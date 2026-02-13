namespace EditPerson
{
    partial class FormMain
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
            personListView = new ListView();
            сolumnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            buttonAdd = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // personListView
            // 
            personListView.Columns.AddRange(new ColumnHeader[] { сolumnHeader1, columnHeader2, columnHeader3 });
            personListView.Dock = DockStyle.Top;
            personListView.FullRowSelect = true;
            personListView.Location = new Point(0, 0);
            personListView.MultiSelect = false;
            personListView.Name = "personListView";
            personListView.Size = new Size(456, 284);
            personListView.TabIndex = 0;
            personListView.UseCompatibleStateImageBehavior = false;
            personListView.View = View.Details;
            personListView.VirtualMode = true;
            personListView.RetrieveVirtualItem += personListView_RetrieveVirtualItem;
            // 
            // сolumnHeader1
            // 
            сolumnHeader1.Text = "Имя";
            сolumnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Фамилия";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Возраст";
            columnHeader3.Width = 150;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(37, 302);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(273, 302);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(154, 34);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 366);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(personListView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список сотрудников";
            ResumeLayout(false);
        }

        #endregion

        private ListView personListView;
        private ColumnHeader сolumnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button buttonAdd;
        private Button buttonEdit;
    }
}
