using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test14_1
{
    
    public partial class Test14_1 : Form
    {

        private Point pStart, pEnd;
        private Graphics g;
        private Pen p;
        private Color c;
        private int width;
        public Test14_1()
        {
            InitializeComponent();
            c = Color.Black;
            width = 1;
            p = new Pen(c,width);
            g = pnlDraw.CreateGraphics();
        }
        private void ReDrawLine(object sender, EventArgs e)
        {
            c = Color.FromArgb((int)nudAlpha.Value, (int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
            width =(int)nudWidth.Value;
            p = new Pen(c, width);
            g.Clear(this.BackColor);
            g.DrawLine(p, pStart, pEnd);
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            pStart = new Point(e.X, e.Y);
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            pEnd = new Point(e.X, e.Y);
            g.DrawLine(p, pStart, pEnd);
        }
    }
}
