namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            userControlTimer1.TimeEnabled = !userControlTimer1.TimeEnabled;
            UpdateButtonText();
        }
        private void UpdateButtonText()
        {
            buttonFix.Text = userControlTimer1.TimeEnabled ? "Пауза" : "Продолжить";
            bntPause.Text = userControl11.TimeEnabled ? "Пауза" : "Продолжить";

        }

        private void bntPause_Click(object sender, EventArgs e)
        {
            userControl11.TimeEnabled = !userControl11.TimeEnabled;
            UpdateButtonText();
        }
    }
}
