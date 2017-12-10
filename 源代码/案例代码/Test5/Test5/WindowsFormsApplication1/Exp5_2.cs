using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Exp5_2 : Form
    {
        public Exp5_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r=Convert.ToDouble(textBox1.Text);
            Circle c=new Circle(r);

            lblShow.Text = "圆形面积为：" + c.Area().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            Rectangle1 r = new Rectangle1(w,h);

            lblShow.Text = "矩形面积为：" + r.Area().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            Triangle t = new Triangle(w, h);

            lblShow.Text = "三角形面积为：" + t.Area().ToString();

        }
    }
    public abstract class Figure 
    {
        public abstract double Area();
    }
    public class Circle : Figure
    {
        double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return radius * radius * 3.14;
        } 
    }
    public class Rectangle1 : Figure
    {
        double high;
        double width ;
        public Rectangle1(double h,double w)
        {
            high = h;
            width = w;
        }
        public override double Area()
        {
            return high * width;
        }
    }
    public class Triangle : Figure
    {
        double high;
        double width;
        public Triangle(double h, double w)
        {
            high = h;
            width = w;
        }
        public override double Area()
        {
            return high * width/2;
        }
    }
}
