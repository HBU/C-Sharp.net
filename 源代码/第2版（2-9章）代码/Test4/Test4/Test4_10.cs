using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_10
{
    public partial class Test4_10 : Form
    {
        public Test4_10()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Phone p;           
            p = new Phone(txtAreaCode.Text, txtPhone.Text);
            //p.InternationalCode = "0086";//错误，不能修改只读字段
            lblShow.Text = string.Format("电话号码是：\n{0} {1} {2}", p.InternationalCode, p.AreaCode, p.telephone);
        }
    }
    class Phone
    {
        //定义字段成员，其中有两个只读字段
        public readonly string InternationalCode = "+86";
        public readonly string AreaCode;
        public string telephone;
        //重载构造函数，以初始化字段成员
        public Phone(string areaCode, string telephone)
        {
            this.AreaCode = areaCode.TrimStart(new char[] { '0' });//删除区号的前导0
            if (telephone.Length == 7)//如是7位，在3、4位间加空格，8位号码在4、5位间空格
                this.telephone = telephone.Insert(3, " ");
            else this.telephone = telephone.Insert(4, " ");
        }       
    }



}
