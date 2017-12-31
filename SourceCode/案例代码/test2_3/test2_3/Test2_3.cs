using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_3
{
    public partial class Test2_3 : Form
    {
        public Test2_3()
        {
            InitializeComponent();
        }
        struct Student                //声明结构型
        {
            //声明结构型的数据成员
            public int no;
            public string name;
            public char sex;
            public int score;
            //声明结构型的方法成员
            public string Answer()
            {
                string result = "该学生的信息如下：";
                result += "\n学号：" + no; 
                result += "\n姓名：" + name;
                result += "\n性别：" + sex;
                result += "\n成绩：" + score;
                return result;       //返回结果
            }
        };

        private void Test2_3_Load(object sender, EventArgs e)
        {
            Student s;                           //使用结构型
            s.no = 1001;
            s.name = "许恒";
            s.sex = '男';
            s.score = 500;
            lblShow.Text = s.Answer();           //显示该生信息
            lblShow.Text += "\n\n" + DateTime.Now; //显示当前时间

        }
    }
}
