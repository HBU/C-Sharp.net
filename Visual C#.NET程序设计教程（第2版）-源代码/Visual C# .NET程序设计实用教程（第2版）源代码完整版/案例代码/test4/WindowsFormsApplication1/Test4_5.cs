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
    public partial class Test4_5 : Form
    {
        public Test4_5()
        {
            InitializeComponent();
        }

       

        private void btnOk_Click(object sender, EventArgs e)
        {
            Analyzer a = new Analyzer();    //创建对象      
            string path = txtPath.Text;
            string dir, file;
            a.SplitPath(path, out dir, out file);   //调用方法,dir和file为输出参数
            txtDir.Text = dir;//显示文件目录
            txtFilename.Text = file;//显示文件名
        }

      
       
    }
    class Analyzer
    {
        //从文件路径中分离目录和文件名，定义了两个输出参数
        public void SplitPath(string path, out string dir, out string filename)
        {
            int i;
            i = path.LastIndexOf('\\');//获取最后一个反斜杠的位置

            dir = path.Substring(0, i);//最后一个反斜杠前的字符串是文件目录
            filename = path.Substring(i + 1);//最后一个反斜杠后的字符串是文件名
        }
    }

}
