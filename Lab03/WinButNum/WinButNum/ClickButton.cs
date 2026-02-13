using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinButNum
{
    internal class ClickButton : System.Windows.Forms.Button
    {
        public int MyClicks { get; private set; }

        protected override void OnClick(EventArgs e)
        {
            MyClicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            System.Drawing.Graphics g = pevent.Graphics;
            System.Drawing.SizeF stringsize;
            stringsize = g.MeasureString(MyClicks.ToString(), this.Font, this.Width);
            g.DrawString(MyClicks.ToString(), this.Font,
            System.Drawing.SystemBrushes.ControlText,
            this.Width - stringsize.Width - 3,
            this.Height - stringsize.Height - 3);
        }

    }

}
