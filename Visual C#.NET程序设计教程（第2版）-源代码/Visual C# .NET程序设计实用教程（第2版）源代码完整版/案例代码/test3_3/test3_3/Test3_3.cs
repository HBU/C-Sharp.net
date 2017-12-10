using System;
using System.Windows.Forms;

namespace test3_3
{
public partial class Test3_3 : Form
{
    public Test3_3()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        char c = Convert.ToChar(txtChar.Text);  //字符串转换为字符型
        if (Char.IsLetter(c))
        {
            if (Char.IsLower(c))
            {
                lblShow.Text = "它是一个小写字母。";
            }
            else if (Char.IsUpper(c))
            {
                lblShow.Text = "它是大写字母。";
            }
            else
            {
                lblShow.Text = "它是中文字符。";
            }
        }
        else if (char.IsNumber(c))
        {
            lblShow.Text = "它是数字。";
        }
        else
        {
            lblShow.Text = "它不是语言文字，也不是数字。";
        }
    }

}
}
