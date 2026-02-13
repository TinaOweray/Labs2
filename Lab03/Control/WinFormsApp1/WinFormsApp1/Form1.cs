namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private User? _user;

        public Form1()
        {
            InitializeComponent();
            userInputControl1.UserValidated += UserInputControl1_UserValidated;
        }

        private void UserInputControl1_UserValidated(object? sender, User user)
        {
            _user = user;
            lblInfo.Text = _user.ToString();
        }
    }
}
