using System;
using System.Windows.Forms;

namespace test3_1
{
public partial class Test3_1 : Form
{
    public Test3_1()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        //提取用户输入并转换为整数
        int age = Convert.ToInt16(txtAge.Text);
            
        if (age < 18)
            lblShow.Text = "该生尚未成年！";
        else
            lblShow.Text = "该生已长大成年！";
    }
}
}
