using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Test7_4
{
    public partial class Test7_4 : Form
    {
        public Test7_4()
        {
            InitializeComponent();
        }

        private void Test7_3_Load(object sender, EventArgs e)
        {
            StreamReader  sr = null;
            try
            {
                sr = new StreamReader(new FileStream(@"D:\test7_4.txt",FileMode.Open));            
                lblShow.Text = sr.ReadLine();
            }
            catch (FileNotFoundException ex)
            {
                lblShow.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblShow.Text = ex.Message;
            }
            finally   //无论是否捕获到异常，都必须执行
            {
                lblShow.Text += "\n执行finally语句。";
                if (sr != null) sr.Close();
            }
        }
    }
}
