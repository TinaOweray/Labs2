namespace BiblWorm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonBookView = new Button();
            buttonAddBook = new Button();
            richTextBoxBooks = new RichTextBox();
            checkBoxBookSortIntNum = new CheckBox();
            checkBoxBookReturnTime = new CheckBox();
            checkBoxBookExistanse = new CheckBox();
            numericUpDownBookPeriodUse = new NumericUpDown();
            numericUpDownBookIntNum = new NumericUpDown();
            numericUpDownBookYear = new NumericUpDown();
            numericUpDownBookPages = new NumericUpDown();
            textBoxBookPublishHouse = new TextBox();
            textBoxBookTitle = new TextBox();
            textBoxBookAuthor = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            checkBoxMagSortInv = new CheckBox();
            buttonShowMag = new Button();
            richTextBoxMag = new RichTextBox();
            buttonAddMagazine = new Button();
            checkBoxMagSubs = new CheckBox();
            checkBoxMagExist = new CheckBox();
            numericUpDownMagInv = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            numericUpDownMagYear = new NumericUpDown();
            numericUpDownMagNumber = new NumericUpDown();
            textBoxMagVolume = new TextBox();
            textBoxMagTitle = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookPeriodUse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookIntNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookPages).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagInv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagNumber).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(841, 432);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.Controls.Add(buttonBookView);
            tabPage1.Controls.Add(buttonAddBook);
            tabPage1.Controls.Add(richTextBoxBooks);
            tabPage1.Controls.Add(checkBoxBookSortIntNum);
            tabPage1.Controls.Add(checkBoxBookReturnTime);
            tabPage1.Controls.Add(checkBoxBookExistanse);
            tabPage1.Controls.Add(numericUpDownBookPeriodUse);
            tabPage1.Controls.Add(numericUpDownBookIntNum);
            tabPage1.Controls.Add(numericUpDownBookYear);
            tabPage1.Controls.Add(numericUpDownBookPages);
            tabPage1.Controls.Add(textBoxBookPublishHouse);
            tabPage1.Controls.Add(textBoxBookTitle);
            tabPage1.Controls.Add(textBoxBookAuthor);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(833, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            // 
            // buttonBookView
            // 
            buttonBookView.Location = new Point(398, 345);
            buttonBookView.Name = "buttonBookView";
            buttonBookView.Size = new Size(130, 34);
            buttonBookView.TabIndex = 19;
            buttonBookView.Text = "Просмотреть";
            buttonBookView.UseVisualStyleBackColor = true;
            buttonBookView.Click += buttonBookView_Click;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(29, 345);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(326, 34);
            buttonAddBook.TabIndex = 18;
            buttonAddBook.Text = "Добавить";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // richTextBoxBooks
            // 
            richTextBoxBooks.Location = new Point(398, 6);
            richTextBoxBooks.Name = "richTextBoxBooks";
            richTextBoxBooks.Size = new Size(427, 319);
            richTextBoxBooks.TabIndex = 17;
            richTextBoxBooks.Text = "";
            // 
            // checkBoxBookSortIntNum
            // 
            checkBoxBookSortIntNum.AutoSize = true;
            checkBoxBookSortIntNum.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxBookSortIntNum.Location = new Point(550, 354);
            checkBoxBookSortIntNum.Name = "checkBoxBookSortIntNum";
            checkBoxBookSortIntNum.Size = new Size(259, 22);
            checkBoxBookSortIntNum.TabIndex = 16;
            checkBoxBookSortIntNum.Text = "Сортировать по инвертарному";
            checkBoxBookSortIntNum.UseVisualStyleBackColor = true;
            // 
            // checkBoxBookReturnTime
            // 
            checkBoxBookReturnTime.AutoSize = true;
            checkBoxBookReturnTime.Location = new Point(150, 304);
            checkBoxBookReturnTime.Name = "checkBoxBookReturnTime";
            checkBoxBookReturnTime.Size = new Size(196, 29);
            checkBoxBookReturnTime.TabIndex = 15;
            checkBoxBookReturnTime.Text = "Возвращает в срок";
            checkBoxBookReturnTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxBookExistanse
            // 
            checkBoxBookExistanse.AutoSize = true;
            checkBoxBookExistanse.Location = new Point(20, 304);
            checkBoxBookExistanse.Name = "checkBoxBookExistanse";
            checkBoxBookExistanse.Size = new Size(108, 29);
            checkBoxBookExistanse.TabIndex = 14;
            checkBoxBookExistanse.Text = "Наличие";
            checkBoxBookExistanse.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBookPeriodUse
            // 
            numericUpDownBookPeriodUse.Location = new Point(174, 264);
            numericUpDownBookPeriodUse.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDownBookPeriodUse.Name = "numericUpDownBookPeriodUse";
            numericUpDownBookPeriodUse.Size = new Size(180, 31);
            numericUpDownBookPeriodUse.TabIndex = 13;
            // 
            // numericUpDownBookIntNum
            // 
            numericUpDownBookIntNum.Location = new Point(175, 222);
            numericUpDownBookIntNum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownBookIntNum.Name = "numericUpDownBookIntNum";
            numericUpDownBookIntNum.Size = new Size(180, 31);
            numericUpDownBookIntNum.TabIndex = 12;
            // 
            // numericUpDownBookYear
            // 
            numericUpDownBookYear.Location = new Point(175, 177);
            numericUpDownBookYear.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownBookYear.Name = "numericUpDownBookYear";
            numericUpDownBookYear.Size = new Size(180, 31);
            numericUpDownBookYear.TabIndex = 11;
            // 
            // numericUpDownBookPages
            // 
            numericUpDownBookPages.Location = new Point(174, 134);
            numericUpDownBookPages.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownBookPages.Name = "numericUpDownBookPages";
            numericUpDownBookPages.Size = new Size(180, 31);
            numericUpDownBookPages.TabIndex = 10;
            // 
            // textBoxBookPublishHouse
            // 
            textBoxBookPublishHouse.Location = new Point(175, 91);
            textBoxBookPublishHouse.Name = "textBoxBookPublishHouse";
            textBoxBookPublishHouse.Size = new Size(150, 31);
            textBoxBookPublishHouse.TabIndex = 9;
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(175, 54);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(150, 31);
            textBoxBookTitle.TabIndex = 8;
            // 
            // textBoxBookAuthor
            // 
            textBoxBookAuthor.Location = new Point(175, 14);
            textBoxBookAuthor.Name = "textBoxBookAuthor";
            textBoxBookAuthor.Size = new Size(150, 31);
            textBoxBookAuthor.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 264);
            label7.Name = "label7";
            label7.Size = new Size(165, 25);
            label7.TabIndex = 6;
            label7.Text = "Срок пользования";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 222);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Инвертарный";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 177);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 4;
            label5.Text = "Год издания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 134);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 3;
            label4.Text = "Страниц";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 91);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Издательство";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Автор";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.Controls.Add(checkBoxMagSortInv);
            tabPage2.Controls.Add(buttonShowMag);
            tabPage2.Controls.Add(richTextBoxMag);
            tabPage2.Controls.Add(buttonAddMagazine);
            tabPage2.Controls.Add(checkBoxMagSubs);
            tabPage2.Controls.Add(checkBoxMagExist);
            tabPage2.Controls.Add(numericUpDownMagInv);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(numericUpDownMagYear);
            tabPage2.Controls.Add(numericUpDownMagNumber);
            tabPage2.Controls.Add(textBoxMagVolume);
            tabPage2.Controls.Add(textBoxMagTitle);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(833, 394);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Журналы";
            // 
            // checkBoxMagSortInv
            // 
            checkBoxMagSortInv.AutoSize = true;
            checkBoxMagSortInv.Font = new Font("Arial", 8F);
            checkBoxMagSortInv.Location = new Point(566, 342);
            checkBoxMagSortInv.Name = "checkBoxMagSortInv";
            checkBoxMagSortInv.Size = new Size(259, 22);
            checkBoxMagSortInv.TabIndex = 10;
            checkBoxMagSortInv.Text = "Сортировать по инвертарному";
            checkBoxMagSortInv.UseVisualStyleBackColor = true;
            // 
            // buttonShowMag
            // 
            buttonShowMag.Location = new Point(398, 333);
            buttonShowMag.Name = "buttonShowMag";
            buttonShowMag.Size = new Size(133, 34);
            buttonShowMag.TabIndex = 9;
            buttonShowMag.Text = "Просмотреть";
            buttonShowMag.UseVisualStyleBackColor = true;
            buttonShowMag.Click += buttonShowMag_Click;
            // 
            // richTextBoxMag
            // 
            richTextBoxMag.Location = new Point(398, 6);
            richTextBoxMag.Name = "richTextBoxMag";
            richTextBoxMag.Size = new Size(427, 319);
            richTextBoxMag.TabIndex = 13;
            richTextBoxMag.Text = "";
            // 
            // buttonAddMagazine
            // 
            buttonAddMagazine.Location = new Point(27, 330);
            buttonAddMagazine.Name = "buttonAddMagazine";
            buttonAddMagazine.Size = new Size(326, 34);
            buttonAddMagazine.TabIndex = 8;
            buttonAddMagazine.Text = "Добавить";
            buttonAddMagazine.UseVisualStyleBackColor = true;
            buttonAddMagazine.Click += buttonAddMagazine_Click;
            // 
            // checkBoxMagSubs
            // 
            checkBoxMagSubs.AutoSize = true;
            checkBoxMagSubs.Location = new Point(168, 233);
            checkBoxMagSubs.Name = "checkBoxMagSubs";
            checkBoxMagSubs.Size = new Size(218, 29);
            checkBoxMagSubs.TabIndex = 7;
            checkBoxMagSubs.Text = "Подписка оформлена";
            checkBoxMagSubs.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagExist
            // 
            checkBoxMagExist.AutoSize = true;
            checkBoxMagExist.Location = new Point(27, 233);
            checkBoxMagExist.Name = "checkBoxMagExist";
            checkBoxMagExist.Size = new Size(108, 29);
            checkBoxMagExist.TabIndex = 6;
            checkBoxMagExist.Text = "Наличие";
            checkBoxMagExist.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMagInv
            // 
            numericUpDownMagInv.Location = new Point(150, 176);
            numericUpDownMagInv.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMagInv.Name = "numericUpDownMagInv";
            numericUpDownMagInv.Size = new Size(122, 31);
            numericUpDownMagInv.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 176);
            label12.Name = "label12";
            label12.Size = new Size(124, 25);
            label12.TabIndex = 8;
            label12.Text = "Инвентарный";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 135);
            label11.Name = "label11";
            label11.Size = new Size(114, 25);
            label11.TabIndex = 7;
            label11.Text = "Год выпуска";
            // 
            // numericUpDownMagYear
            // 
            numericUpDownMagYear.Location = new Point(150, 133);
            numericUpDownMagYear.Maximum = new decimal(new int[] { 2999, 0, 0, 0 });
            numericUpDownMagYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDownMagYear.Name = "numericUpDownMagYear";
            numericUpDownMagYear.Size = new Size(84, 31);
            numericUpDownMagYear.TabIndex = 4;
            numericUpDownMagYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // numericUpDownMagNumber
            // 
            numericUpDownMagNumber.Location = new Point(150, 89);
            numericUpDownMagNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMagNumber.Name = "numericUpDownMagNumber";
            numericUpDownMagNumber.Size = new Size(122, 31);
            numericUpDownMagNumber.TabIndex = 3;
            // 
            // textBoxMagVolume
            // 
            textBoxMagVolume.Location = new Point(150, 54);
            textBoxMagVolume.Name = "textBoxMagVolume";
            textBoxMagVolume.Size = new Size(203, 31);
            textBoxMagVolume.TabIndex = 2;
            // 
            // textBoxMagTitle
            // 
            textBoxMagTitle.Location = new Point(150, 17);
            textBoxMagTitle.Name = "textBoxMagTitle";
            textBoxMagTitle.Size = new Size(203, 31);
            textBoxMagTitle.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 95);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 2;
            label10.Text = "Номер";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 54);
            label9.Name = "label9";
            label9.Size = new Size(45, 25);
            label9.TabIndex = 1;
            label9.Text = "Том";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 17);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 0;
            label8.Text = "Название";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 432);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Библиотека";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookPeriodUse).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookIntNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookPages).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagInv).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMagNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxBookPublishHouse;
        private TextBox textBoxBookTitle;
        private TextBox textBoxBookAuthor;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonBookView;
        private Button buttonAddBook;
        private RichTextBox richTextBoxBooks;
        private CheckBox checkBoxBookSortIntNum;
        private CheckBox checkBoxBookReturnTime;
        private CheckBox checkBoxBookExistanse;
        private NumericUpDown numericUpDownBookPeriodUse;
        private NumericUpDown numericUpDownBookIntNum;
        private NumericUpDown numericUpDownBookYear;
        private NumericUpDown numericUpDownBookPages;
        private Label label8;
        private Label label9;
        private TextBox textBoxMagVolume;
        private TextBox textBoxMagTitle;
        private Label label10;
        private NumericUpDown numericUpDownMagYear;
        private NumericUpDown numericUpDownMagNumber;
        private Label label11;
        private Button buttonAddMagazine;
        private CheckBox checkBoxMagSubs;
        private CheckBox checkBoxMagExist;
        private NumericUpDown numericUpDownMagInv;
        private Label label12;
        private RichTextBox richTextBoxMag;
        private CheckBox checkBoxMagSortInv;
        private Button buttonShowMag;
    }
}
