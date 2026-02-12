namespace TestList_
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
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSort = new Button();
            memberList = new CheckedListBox();
            peopleList = new ComboBox();
            groupBox1 = new GroupBox();
            buttoninport = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(328, 36);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(328, 76);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(304, 116);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(136, 34);
            buttonSort.TabIndex = 2;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // memberList
            // 
            memberList.FormattingEnabled = true;
            memberList.Location = new Point(35, 45);
            memberList.Name = "memberList";
            memberList.Size = new Size(211, 200);
            memberList.TabIndex = 3;
            // 
            // peopleList
            // 
            peopleList.FormattingEnabled = true;
            peopleList.Items.AddRange(new object[] { "Иванов Иван Иванович", "Петров Петр Петрович", "Магдаления Ив Пыж" });
            peopleList.Location = new Point(35, 260);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(182, 33);
            peopleList.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(35, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 32);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "список участников";
            // 
            // buttoninport
            // 
            buttoninport.Location = new Point(256, 264);
            buttoninport.Name = "buttoninport";
            buttoninport.Size = new Size(184, 34);
            buttoninport.TabIndex = 6;
            buttoninport.Text = "Загрузить данные";
            buttoninport.UseVisualStyleBackColor = true;
            buttoninport.Click += buttoninport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 356);
            Controls.Add(buttoninport);
            Controls.Add(groupBox1);
            Controls.Add(peopleList);
            Controls.Add(memberList);
            Controls.Add(buttonSort);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Работа со списками";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSort;
        private CheckedListBox memberList;
        private ComboBox peopleList;
        private GroupBox groupBox1;
        private Button buttoninport;
    }
}
