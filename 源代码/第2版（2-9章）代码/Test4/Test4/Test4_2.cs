using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_2
{
    public partial class Test4_2 : Form
    {
        public Test4_2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.Radius = Convert.ToDouble(txtRadius.Text);
            lblShow.Text = string.Format("半径为{0}的圆的面积为：{1:N2}", circle.Radius, circle.Area);
        }
        

    }
    class Circle
    {
        private const double pi = 3.1415926;
        private double radius;
        public double Radius//可读、写属性
        {
            get{return radius;}
            set{
                if (value < 0) radius = 0;
                else radius = value;
            }
        }
        public double Area//只读属性
        {
            get{return pi * Radius * Radius;}
        }
    }
}
 