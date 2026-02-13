using System.Globalization;

namespace FunctionCalculation
{
    public partial class IntervalForm : Form
    {
        public double A { get; private set; }
        public double B { get; private set; }

        public IntervalForm()
        {
            InitializeComponent();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Разрешим ввод и через точку, и через запятую
            string sa = textBoxA.Text.Trim().Replace(',', '.');
            string sb = textBoxB.Text.Trim().Replace(',', '.');

            if (!double.TryParse(sa, NumberStyles.Float, CultureInfo.InvariantCulture, out double a))
            {
                MessageBox.Show("Неверно введена левая граница.");
                return;
            }

            if (!double.TryParse(sb, NumberStyles.Float, CultureInfo.InvariantCulture, out double b))
            {
                MessageBox.Show("Неверно введена правая граница.");
                return;
            }

            if (a >= b)
            {
                MessageBox.Show("Левая граница должна быть меньше правой.");
                return;
            }

            A = a;
            B = b;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
