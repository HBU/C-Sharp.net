using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace test12_3
{
    public partial class Test12_7 : Form
    {
        public Test12_7()
        {
            InitializeComponent();
        }

        //private XmlTextWriter tw;

        private XmlDocument doc;
        private XmlElement root;
private void btnAdd_Click(object sender, EventArgs e)
{
    XmlElement student = doc.CreateElement("学生");   //4. 创建学生元素

    XmlAttribute attr = doc.CreateAttribute("类别");  //5. 创建学生元素的各属性
    attr.Value = cmbType.Text;
    student.Attributes.Append(attr);

    attr = doc.CreateAttribute("学号");
    attr.Value = txtNo.Text;
    student.Attributes.Append(attr);

    XmlElement elem = doc.CreateElement("姓名");      //6. 创建学生元素的各子元素
    attr = doc.CreateAttribute("中文名");
    attr.Value = txtCnName.Text;
    elem.Attributes.Append(attr);
    attr = doc.CreateAttribute("英文名");
    attr.Value = txtEnName.Text;
    elem.Attributes.Append(attr);
    student.AppendChild(elem);

    elem = doc.CreateElement("性别");
    string sex="";
    if(rdoMale.Checked)
        sex = rdoMale.Text;
    else
        sex = rdoFemale.Text;
    XmlText text = doc.CreateTextNode(sex);
    elem.AppendChild(text);
    student.AppendChild(elem);

    elem = doc.CreateElement("电话");
    text = doc.CreateTextNode(txtTel.Text);
    elem.AppendChild(text);
    student.AppendChild(elem);

    root.AppendChild(student);    //7. 把学生元素添加到根元素之中                           
}

        private void btnStart_Click(object sender, EventArgs e)
        {
            doc = new XmlDocument();         //1. 创建文档对象
            XmlDeclaration declare = doc.CreateXmlDeclaration("1.0","utf-8","yes");
            doc.AppendChild(declare);        //2. 添加声明语句
            root = doc.CreateElement("学生列表");
            doc.AppendChild(root);           //3. 添加根元素
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            doc.Save(@"d:\data\students.xml");  //8.保存XML文档
        }
    }
}
