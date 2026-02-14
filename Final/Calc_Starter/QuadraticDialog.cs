using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class QuadraticDialog : Form
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public QuadraticDialog()
        {
            InitializeComponent();

            txtA.KeyPress += Coeff_KeyPress;
            txtB.KeyPress += Coeff_KeyPress;
            txtC.KeyPress += Coeff_KeyPress;
        }

        private void Coeff_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем управляющие клавиши (Backspace, Ctrl+C/V/X и т.п.)
            if (char.IsControl(e.KeyChar))
                return;

            var tb = (TextBox)sender;

            // Разрешаем цифры
            if (char.IsDigit(e.KeyChar))
                return;

            // Разрешаем десятичный разделитель '.' или ','
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // нельзя первым символом 
                if (tb.SelectionStart == 0 && tb.TextLength == 0)
                {
                    e.Handled = true;
                    return;
                }

                // только один разделитель
                if (tb.Text.Contains('.') || tb.Text.Contains(','))
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Разрешаем минус только в начале и только один
            if (e.KeyChar == '-')
            {
                // минус можно вставить только в позицию 0
                if (tb.SelectionStart != 0) { e.Handled = true; return; }

                // и только если его ещё нет
                if (tb.Text.Contains('-')) { e.Handled = true; return; }

                return;
            }

            // Всё остальное запрещаем
            e.Handled = true;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (!TryParseCoeff(txtA.Text, out double a) ||
                !TryParseCoeff(txtB.Text, out double b) ||
                !TryParseCoeff(txtC.Text, out double c))
            {
                MessageBox.Show(
                    "Введите корректные числа a, b, c.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.DialogResult = DialogResult.None; // не закрывать
                return;
            }

            A = a; B = b; C = c;
            // DialogResult.OK уже выставлен в свойствах кнопки, форма закроется
        }

        private static bool TryParseCoeff(string s, out double value)
        {
            s = (s ?? "").Trim();

            // Разрешаем ввод через запятую
            s = s.Replace(',', '.');

            return double.TryParse(
                s,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out value
            );
        }
    }
}
