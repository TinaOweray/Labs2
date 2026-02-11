namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using var myPath = new System.Drawing.Drawing2D.GraphicsPath();

            Point[] diamond =
            {
                new Point(Width / 2, 0),          // верх
                new Point(Width, Height / 2),     // право
                new Point(Width / 2, Height),     // низ
                new Point(0, Height / 2)          // лево
            };

            myPath.AddPolygon(diamond);
            Region = new Region(myPath);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
