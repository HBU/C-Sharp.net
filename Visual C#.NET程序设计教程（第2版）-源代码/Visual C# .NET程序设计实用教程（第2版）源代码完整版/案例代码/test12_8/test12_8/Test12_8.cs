using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace test12_4
{
    public partial class Test12_8 : Form
    {
        public Test12_8()
        {
            InitializeComponent();
        }

        private void Test12_4_Load(object sender, EventArgs e)
        {
            //XmlTextReader tr = new XmlTextReader(@"d:\data\students.xml");
            //while (tr.Read())
            //{
            //    switch (tr.Name)
            //    {
            //        case "学生":
            //            if(tr.IsStartElement())
            //                lblShow.Text += "学号：" + tr.GetAttribute("学号");
            //            break;
            //        case "姓名":
            //            lblShow.Text += ",姓名：" + tr.GetAttribute("中文名");
            //            break;
            //        case "性别":
            //            lblShow.Text += ",性别：" + tr.ReadInnerXml();
            //            break;
            //        case "电话":
            //            lblShow.Text += ",电话：" + tr.ReadInnerXml() + "\n";
            //            break;
            //    }
            //}
            //tr.Close();

            //XPathDocument doc = new XPathDocument(@"d:\data\students.xml");
            //XPathNavigator nav = doc.CreateNavigator();
            //XPathExpression expr = nav.Compile("学生列表/学生/电话[../姓名/@中文名='万小易']");
            //XPathNodeIterator ni = nav.Select(expr);
            //if (ni.MoveNext())
            //    lblShow.Text += ni.Current.Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            XPathDocument doc = new XPathDocument(@"d:\data\students.xml");
            XPathNavigator nav = doc.CreateNavigator();
            XPathExpression expr = nav.Compile("学生列表/学生[@学号=" + txtNo.Text + "]");
            XPathNodeIterator ni = nav.Select(expr);
            while (ni.MoveNext())
            {
                lblShow.Text = "类别：" + ni.Current.GetAttribute("类别", "");
                XPathNodeIterator sni = ni.Current.SelectChildren("姓名", "");
                sni.MoveNext();
                lblShow.Text += "，姓名：" + sni.Current.GetAttribute("中文名", "");
                sni = (XPathNodeIterator)ni.Current.Evaluate("性别/text()");
                sni.MoveNext();
                lblShow.Text += "，性别：" + sni.Current.Value;
                sni = (XPathNodeIterator)ni.Current.Evaluate("电话/text()");
                sni.MoveNext();
                lblShow.Text += "，电话：" + sni.Current.Value;
            }
        }
    }
}
