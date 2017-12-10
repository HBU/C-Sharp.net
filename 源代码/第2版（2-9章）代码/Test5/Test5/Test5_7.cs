using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test5_7
{
    public partial class Test5_7 : Form
    {
        public Test5_7()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
            x1 = Convert.ToInt32(txtLx.Text);
            x2 = Convert.ToInt32(txtRx.Text);
            y1 = Convert.ToInt32(txtLy.Text);
            y2 = Convert.ToInt32(txtRy.Text);
            Rectangle ra = new Rectangle(x1, y1, x2, y2);
            lblShow.Text = string.Format("长方形的面积为：{0}.",ra.Area);
          
            
            
        }

       
    }
    class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;
        public Rectangle(int lx, int ly, int rx, int ry)
        {
            topLeft = new Point(lx, ly);
            bottomRight = new Point(rx, ry);
        }
        class Point
        {
            int x;
            int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int X
            {
                get { return x; }
            }
            public int Y
            {
                get { return y; }
            }
        }
        public int Area
        {
            get
            {
                return (bottomRight.X - topLeft.X) * (bottomRight.Y - topLeft.Y);
            }
        }
    }
    


}
