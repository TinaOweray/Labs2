namespace FunctionCalculation
{
    public partial class FormSinX : Form
    {
        double? a = null;
        double? b = null;
        public FormSinX()
        {
            InitializeComponent();
        }

        private void buttonSetInterval_Click(object sender, EventArgs e)
        {
            using (var dlg = new IntervalForm())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    a = dlg.A;
                    b = dlg.B;

                    labelInterval.Text = $"Левая граница: {a:0.###}, правая граница: {b:0.###}";
                    CalculateAndShow();
                }
            }
        }
        private void CalculateAndShow()
        {
            if (a == null || b == null) return;

            richTextBoxResult.Clear();

            double step = 0.1; 
            for (double x = a.Value; x <= b.Value + 1e-9; x += step)
            {
                double y = Math.Sin(x);
                richTextBoxResult.AppendText($"{x:0.0}\t{y:0.###}{Environment.NewLine}");
            }
        }
    }
}
