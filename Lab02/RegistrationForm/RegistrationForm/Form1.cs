using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(18, 126);
                //lbl.Size = new System.Drawing.Size(45, 25);
                lbl.AutoSize = true;
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(81, 126);
                txt.Size = new System.Drawing.Size(180, 31);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                //txt.KeyPress += new
                //System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
                txt.Validating += textBox2_Validating;
                groupBox1.Controls.Add(txt);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "");
                return;
            }

            bool hasDigit = textBox1.Text.Any(char.IsDigit);
            errorProvider1.SetError(textBox1, hasDigit ? "Must be letters (no digits)" : "");
                  
            //errorProvider1.SetError(textBox1, "Must be letter");
        }
        //{
        //    if (char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Поле Name не может содержать цифры");
        //    }

        //}

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;

            if (tb.Text == "")
            {
                e.Cancel = false;
                return;
            }

            if (!tb.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                MessageBox.Show("Поле PIN не может содержать буквы");
                tb.Text = "";
            }
            else
            {
                e.Cancel = false;
            }

            //if (textBox2.Text == "")
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    try
            //    {
            //        double.Parse(textBox2.Text);
            //        e.Cancel = false;
            //    }
            //    catch
            //    {
            //        e.Cancel = true;
            //        MessageBox.Show("Поле PIN не может содержать буквы");
            //        textBox2.Text = "";
            //    }
            //}

        }
        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Поле PIN не может содержать буквы");
        //    }
        //}
    }
}
