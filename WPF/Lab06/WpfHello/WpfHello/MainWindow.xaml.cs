using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isDataDirty = false;
        string nameFile = "username.txt";

        public MyWindow myWin { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            lbl.Content = "Добрый день!";
            setBut.IsEnabled = false;
            retBut.IsEnabled = false;
            Top = 25;
            Left = 25;

            CommandBinding abinding = new CommandBinding();
            abinding.Command = CustomCommands.Launch;
            abinding.Executed += new ExecutedRoutedEventHandler(Launch_Handler);
            abinding.CanExecute += new CanExecuteRoutedEventHandler(LaunchEnabled_Handler);
            this.CommandBindings.Add(abinding);
        }

        private void LaunchEnabled_Handler(object sender,CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (bool)check.IsChecked;
        }

        private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            if (myWin == null)
                myWin = new MyWindow();
            myWin.Owner = this;
            var location = New_Win.PointToScreen(new Point(0, 0));
            myWin.Left = location.X + New_Win.Width;
            myWin.Top = location.Y;
            myWin.Show();
        }

        private void SetBut()
        {
            try
            {
                using (var sw = new System.IO.StreamWriter(nameFile, false))
                {
                    sw.WriteLine(setText.Text);
                }

                retBut.IsEnabled = true;
                isDataDirty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RetBut()
        {
            try
            {
                string text;
                using (var sr = new System.IO.StreamReader(nameFile))
                {
                    text = sr.ReadToEnd();
                }

                retLabel.Content = "Приветствую Вас, \n" +
                                    "уважаемый " + text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setText_TextChanged(object sender, TextChangedEventArgs e)
        {
            setBut.IsEnabled = true;
            isDataDirty = true;
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            {
                if (this.isDataDirty)
                {
                    string msg = "Данные были изменены, но не сохранены!\n Закрыть окно без сохранения ? ";

                    MessageBoxResult result = MessageBox.Show(msg, "Контроль данных", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void New_Win_Click_1(object sender, RoutedEventArgs e)
        //{
        //    if (myWin == null)
        //        myWin = new MyWindow();
        //    myWin.Owner = this;
        //    var location = New_Win.PointToScreen(new Point(0, 0));
        //    myWin.Left = location.X + New_Win.Width;
        //    myWin.Top = location.Y;
        //    myWin.Show();
        //}

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            try
            {
                switch (feSource.Name)
                {
                    case "setBut":
                        SetBut();
                        break;
                    case "retBut":
                        RetBut();
                        break;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
