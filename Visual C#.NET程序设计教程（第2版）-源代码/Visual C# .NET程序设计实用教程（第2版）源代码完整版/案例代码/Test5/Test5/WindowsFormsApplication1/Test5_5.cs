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
    public partial class Test5_5 : Form
    {
        public Test5_5()
        {
            InitializeComponent();
            
        }

       
        private void Display(Shape s)
        {
            lblShow.Text = "体积为：" + s.Cubage();
        }

        private void btnGlobe_Click(object sender, EventArgs e)
        {
            double r=Convert.ToDouble(txtRadius.Text);
            Globe g = new Globe(r);
            Display(g);
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double h = Convert.ToDouble(txtHigh.Text);
            Cone co = new Cone(r,h);
            Display(co);
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double h = Convert.ToDouble(txtHigh.Text);
            Cylinder cy = new Cylinder(r, h);
            Display(cy);

        }
    }
    public abstract class Shape
    {
        protected double radius;
        public Shape(double r){ radius = r; }  //构造函数
        public abstract double Cubage();  //声明抽象方法
       
    }
    public  class Globe : Shape  //定义派生类Globe（圆球体）
    {
        public Globe(double r) : base(r) { } //构造函数
        public override double Cubage()//重写抽象方法
        {
            return 3.14 * radius * radius * radius * 4.0 / 3; ;
        }
    }
    public class Cone : Shape //定义派生类Cone（圆锥体）
    {
        private double high;
        public Cone(double r, double h) : base(r) { high = h; }
        public override double  Cubage()//重写抽象方法
        {
            return 3.14 * radius * radius * high/3;
        }
    }
    public class Cylinder : Shape//定义派生类Cylinder（圆柱体）
    {
        private double high;
        public Cylinder(double r, double h) : base(r) { high = h; }
        public override double Cubage()//重写抽象方法
        {
            return 3.14 * radius * radius * high;
        }

    }
}
