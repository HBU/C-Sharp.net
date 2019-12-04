using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test4_1
{
    public partial class Test4_7 : Form
    {
        public Test4_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maxer m = new Maxer();    				//创建对象
            int[] a = new int[] { 4, 7, 1, 3, 2, 8, 6, 5 };
            int max = m.Max(a);      				//调用方法，实参为已初始化的数组
            txtMax.Text = max.ToString();
            max = m.MaxP(4, 7, 1, 3, 2, 8, 6, 5);  	//调用方法，实参为数据列表
            txtMaxP.Text = max.ToString();

        }
    }
    class Maxer
    {
        //求最大数，形参为普通数组，实参必须为数组
        public int Max(int[] numbers)
        {
            int k = 0;
            //求最大数的索引
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[k] < numbers[i])
                    k = i;
            }
            return numbers[k];
        }

        //求最大数，形参为params数组，实参可使用数据列表
        public int MaxP(params int[] numbers)
        {
            int k = 0;
            //求最大数的索引
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[k] < numbers[i])
                    k = i;
            }
            return numbers[k];
        }
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public double Max(double a, double b)
        {
            return a > b ? a : b;
        }
        public int Max(int a, int b, int c)
        {
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            return max;
        }
        
    }
  

}
