using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        Form1 myF1;

        public Form2()
        {
            InitializeComponent();
            myF1 = new Form1();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            myF1 = new Form1();
            myF1.StartPosition = FormStartPosition.CenterScreen;
            myF1.Show();

        }
    }
}
