using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test8_4
{
    public partial class Test8_4 : Form
    {
        public Test8_4()
        {
            InitializeComponent();
        }

        

    private void txtSource_Enter(object sender, EventArgs e)
    {
        txtSource.Text = "";            
        txtSource.TextChanged+=new EventHandler(txtSource_TextChanged);
    }

    private void txtSource_TextChanged(object sender, EventArgs e)
    {
        lblShow.Text = "正在输入：";
        lblTarget.Text =  txtSource.Text;
    }

    private void txtSource_Leave(object sender, EventArgs e)
    {
        lblShow.Text = "输入结束，您输入的文字是：";
        txtSource.TextChanged -= new EventHandler(txtSource_TextChanged);
        txtSource.Text = "在此，请输入任意文字！";
    }

        

       
    }
}
