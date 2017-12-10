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
    public partial class Test4_10 : Form
    {
        public Test4_10()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Park p;
            decimal price=Convert.ToDecimal(txtPrice.Text);
            p = new Park(txtAddress.Text, price);
            //p.name = "成都新华公园";
            lblShow.Text = string.Format("{0}\n地址：{1}\n门票：{2}", p.name, p.address, p.price);
        }
    }
    class Park
    {
        //定义字段成员，其中有两个只读字段
        public readonly string name = "成都胜利公园";
        public readonly string address;
        public decimal price;
        //重载构造函数，以初始化字段成员
        public Park(string address,decimal price)
        {
            this.address = address;
            this.price = price;
        }       
    }



}
