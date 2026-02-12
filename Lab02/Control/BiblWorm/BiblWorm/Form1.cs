using MyClass;
using System.Collections.Generic;
using System.Text;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        //List<Item> its = new List<Item>();
        List<Book> books = new List<Book>();
        List<Magazine> magazines = new List<Magazine>();

        public Form1()
        {
            InitializeComponent();
        }

        public string Author // автор
        {
            get { return textBoxBookAuthor.Text; }
            set { textBoxBookAuthor.Text = value; }
        }


        public string Title // Название
        {
            get { return textBoxBookTitle.Text; }
            set { textBoxBookTitle.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBoxBookPublishHouse.Text; }
            set { textBoxBookPublishHouse.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numericUpDownBookPages.Value; }
            set { numericUpDownBookPages.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDownBookYear.Value; }
            set { numericUpDownBookYear.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDownBookIntNum.Value; }
            set { numericUpDownBookIntNum.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBoxBookExistanse.Checked; }
            set { checkBoxBookExistanse.Checked = value; }
        }
        public bool BookSortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBoxBookSortIntNum.Checked; }
            set { checkBoxBookSortIntNum.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBoxBookReturnTime.Checked; }
            set { checkBoxBookReturnTime.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDownBookPeriodUse.Value; }
            set { numericUpDownBookPeriodUse.Value = value; }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
            Page, Year, InvNumber, Existence);

            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            books.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void buttonBookView_Click(object sender, EventArgs e)
        {
            if (BookSortInvNumber)
                books.Sort(); 

            StringBuilder sb = new StringBuilder();
            foreach (Book b in books)
            {
                sb.Append("\n" + b.ToString());
            }

            richTextBoxBooks.Text = sb.ToString();
        }

        private void buttonAddMagazine_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(
                                MagVolume,
                                MagNumber,
                                MagTitle,
                                MagYear,
                                MagInvNumber,
                                MagExistence);

            m.IfSubs = MagSubs;
            if (MagSubs) m.Subs();

            magazines.Add(m);

            // очистка полей (как у книг)
            MagTitle = MagVolume = "";
            MagNumber = 0;
            MagYear = 2026;
            MagInvNumber = 0;
            MagExistence = false;
            MagSubs = false;
        }

        private void buttonShowMag_Click(object sender, EventArgs e)
        {
            if (MagSortInvNumber)
                magazines.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Magazine m in magazines)
            {
                sb.Append("\n" + m.ToString());
            }

            richTextBoxMag.Text = sb.ToString();
        }

        public string MagTitle
        {
            get { return textBoxMagTitle.Text; }
            set { textBoxMagTitle.Text = value; }
        }

        public string MagVolume
        {
            get { return textBoxMagVolume.Text; }
            set { textBoxMagVolume.Text = value; }
        }

        public int MagNumber
        {
            get { return (int)numericUpDownMagNumber.Value; }
            set { numericUpDownMagNumber.Value = value; }
        }

        public int MagYear
        {
            get { return (int)numericUpDownMagYear.Value; }
            set { numericUpDownMagYear.Value = value; }
        }

        public int MagInvNumber
        {
            get { return (int)numericUpDownMagInv.Value; }
            set { numericUpDownMagInv.Value = value; }
        }
        public bool MagSortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBoxMagSortInv.Checked; }
            set { checkBoxMagSortInv.Checked = value; }
        }

        public bool MagExistence
        {
            get { return checkBoxMagExist.Checked; }
            set { checkBoxMagExist.Checked = value; }
        }

        public bool MagSubs
        {
            get { return checkBoxMagSubs.Checked; }
            set { checkBoxMagSubs.Checked = value; }
        }
    }
}

