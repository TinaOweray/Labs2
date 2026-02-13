namespace EditPerson
{
    public partial class FormMain : Form
    {
        List<Person> pers = new List<Person>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //EditPersonForm editForm = new EditPersonForm();

            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;

            //ListViewItem newItem = personListView.Items.Add(editForm.FirstName);
            //newItem.SubItems.Add(editForm.LastName);
            //newItem.SubItems.Add(editForm.Age.ToString());

            Person p = new Person();

            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            pers.Add(p);

            personListView.VirtualListSize = pers.Count;
            personListView.Invalidate();
        }
        private void personListView_RetrieveVirtualItem(object sender,RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (personListView.SelectedIndices.Count == 0)
                return;
            Person p = pers[personListView.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personListView.Invalidate();
            }


            //if (personListView.SelectedItems.Count == 0)
            //    return;
            //ListViewItem item = personListView.SelectedItems[0];

            //EditPersonForm editForm = new EditPersonForm();
            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;
            //item.Text = editForm.FirstName;
            //item.SubItems[1].Text = editForm.LastName;
            //item.SubItems[2].Text = editForm.Age.ToString();

        }




    }
}
