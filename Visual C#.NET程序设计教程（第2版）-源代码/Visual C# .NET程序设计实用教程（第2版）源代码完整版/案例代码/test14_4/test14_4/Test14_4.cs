using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace test14_4
{
    public partial class Test14_4 : Form
    {
        private Graphics g;       //声明绘图对象
        private Pen p;            //声明钢笔对象
        private Rectangle rect1, rect2;  //声明两个矩形区域
        private float angle, langle;     //保存全局旋转和局部旋转的角度
        private float dx, dy, ldx, ldy;  //保存全局缩放或局部缩放的比例
        private float mx, my, lmx, lmy;  //保存全局平移或局部平移的分量

        public Test14_4()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Blue);
            rect1 = new Rectangle(0, 0, 100, 50);
            rect2 = new Rectangle(150, 0, 100, 50);
            angle = 0; langle = 0;
            dx = 1; dy = 1; ldx = 1; ldy = 1;
            mx = 0; my = 0; lmx = 0; lmx = 0;
        }

        private void ngRotate_ValueChanged(object sender, EventArgs e)
        {
            angle =Convert.ToSingle(ngRotate.Value);
            this.Refresh();
        }

        private void ngxScale_ValueChanged(object sender, EventArgs e)
        { 
            dx = Convert.ToSingle(ngxScale.Value);
            this.Refresh();
        }

        private void ngyScale_ValueChanged(object sender, EventArgs e)
        {
            dy = Convert.ToSingle(ngyScale.Value);
            this.Refresh();
        }

        private void ngxMove_ValueChanged(object sender, EventArgs e)
        {
            mx = Convert.ToSingle(ngxMove.Value);
            this.Refresh();
        }

        private void ngyMove_ValueChanged(object sender, EventArgs e)
        {
            my = Convert.ToSingle(ngyMove.Value);
            this.Refresh();
        }

  
        private void nlRotate_ValueChanged(object sender, EventArgs e)
        {
            langle = Convert.ToSingle(nlRotate.Value);
            this.Refresh();
        }

        private void nlxScale_ValueChanged(object sender, EventArgs e)
        {
            ldx = Convert.ToSingle(nlxScale.Value);
            this.Refresh();
        }

        private void nlyScale_ValueChanged(object sender, EventArgs e)
        {
            ldy = Convert.ToSingle(nlyScale.Value);
            this.Refresh();
        }

        private void nlxMove_ValueChanged(object sender, EventArgs e)
        {
            lmx = Convert.ToSingle(nlxMove.Value);
            this.Refresh();
        }

        private void nlyMove_ValueChanged(object sender, EventArgs e)
        {
            lmy = Convert.ToSingle(nlyMove.Value);
            this.Refresh();
        }

        private void Test14_4_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();  //创建绘画对象
            g.Clear(this.BackColor);    //清除原来绘图
            g.RotateTransform(angle);   //启用全局旋转变形
            g.ScaleTransform(dx, dy);   //启用全局缩放变形
            g.TranslateTransform(mx, my); //启用全局平移变形

            GraphicsPath gp = new GraphicsPath();  //创建绘图路径对象
            gp.AddEllipse(rect1);      //指定在第一个矩形区域中绘制椭圆
            Matrix m = new Matrix();   //创建矩阵对象
            float r = Convert.ToSingle(nlRotate.Value);
            m.Rotate(r);    //设置局部旋转变形的角度
            m.Scale(ldx, ldy); //设置局部缩放变形的比例
            m.Translate(lmx, lmy);  //设置局部平移量
            gp.Transform(m);    //将局部变形矩阵应用到绘图路径
            g.DrawPath(p, gp);  //根据绘图路径的要求绘图
            g.DrawRectangle(p, rect2); //绘制矩形
        }
    }
}
