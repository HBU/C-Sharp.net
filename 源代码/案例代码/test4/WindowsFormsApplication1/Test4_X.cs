using System;
using System.Windows.Forms;

namespace test4_1
{
    public partial class Test4_X : Form
    {
        public Test4_X()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //int x1, x2, y1, y2;
            //x1 = Convert.ToInt32(txtLx.Text);
            //x2 = Convert.ToInt32(txtRx.Text);
            //y1 = Convert.ToInt32(txtLy.Text);
            //y2 = Convert.ToInt32(txtRy.Text);
            //Rectangle ra = new Rectangle(x1, y1, x2, y2);
            //lblShow.Text = string.Format("长方形的面积为：{0}.",ra.Area);
            DemoString ds=new DemoString();
            string str="sssss";
            ds.TestString(str);
            lblShow.Text = str;
            
            
        }

       
    }
    class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;
        public  Rectangle(int lx,int ly,int rx,int ry )
        {
            topLeft=new Point(lx,ly);
            bottomRight=new Point(rx,ry);
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
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
    class Add
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public string DisPlay(int a, int b)
        {
            return string.Format("{0}+{1}={2}",a,b,Sum(a,b));//调用自身类的Sum方法。
        }
    }
    class Use
    {
        public string DisPlay(int a, int b)
        {
            Add add = new Add();//先要创建类的对象
            return string.Format("{0}+{1}={2}", a, b, add.Sum(a, b));//调用其它类的Sum方法。
        }
    }
    class DemoString
    {
       public void TestString(string str)
        {
            str = "你好";
        }

    }



}
