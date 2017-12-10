using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3_2
{
public partial class Test3_2 : Form
{
    public Test3_2()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        float total=0;
        float amount =Convert.ToSingle( txtAmount.Text);

        bool isValid = true;
        switch (Convert.ToInt16(txtType.Text))
        {
            case 1: total = amount * 350; break;
            case 2: total = amount * 780; break;
            case 3: total = amount * 1320; break;
            default: isValid = false ; break;
        }
        if (isValid)
            lblShow.Text = "应付款：" + total.ToString("N2") + "元。\n谢谢惠顾！";
        else
            lblShow.Text = "类别代码无效！请重新输入。";

     }
}
}
