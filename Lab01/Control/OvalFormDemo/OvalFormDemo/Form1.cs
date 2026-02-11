using System.Drawing.Drawing2D;

namespace OvalFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region = new System.Drawing.Region(myPath);

        }
    }
}
