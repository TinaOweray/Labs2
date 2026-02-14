using System.Windows;

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        private bool _close;
        MainWindow wnd1 = null;
        public MyWindow()
        {
            InitializeComponent();
        }

        public new void Close()
        {
            _close = true;
            base.Close();
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_close) return;
            e.Cancel = true;
            Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wnd1 = Owner as MainWindow;
            if (wnd1 != null)
            {
                wnd1.txtBlock.Text = textBox.Text;
                PrintLogFile();
            }
            Close();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            wnd1.myWin = null;
        }

        private void PrintLogFile()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt",true))
            {
                writer.WriteLine("Внесено {0}: {1} ", textBox.Text,
               DateTime.Now.ToShortDateString() + ", время: " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }
        }
    }
}
