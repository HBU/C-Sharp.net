using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace test14_2
{
    public partial class Test14_2 : Form
    {

        private Graphics g;
        private Pen p;
        private bool isMouseDown;
        private Point pStart, pEnd;

        public Test14_2()
        {
            InitializeComponent();
            p = new Pen(Color.Black);
            g = this.CreateGraphics();
            isMouseDown = false;
        }

        private void Test14_2_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            pStart = new Point(e.X, e.Y);
        }

        private void Test14_2_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Test14_2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                pEnd = new Point(e.X, e.Y);
                g.DrawLine(p, pStart, pEnd);
                pStart = pEnd;
            }
        }
    }
}
