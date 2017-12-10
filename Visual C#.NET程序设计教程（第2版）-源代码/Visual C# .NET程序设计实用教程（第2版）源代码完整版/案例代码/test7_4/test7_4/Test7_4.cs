using System;
using System.Windows.Forms;
using System.IO;

namespace test7_4
{
public partial class Test7_4 : Form
{
    public Test7_4()
    {
        InitializeComponent();
    }

    private void Test7_4_Load(object sender, EventArgs e)
    {
        StreamReader  sr = null;
        try
        {
            sr = new StreamReader(new FileStream(@"D:\test7_4.txt",FileMode.Open));
            lblShow.Text = sr.ReadLine();
        }
        catch (FileNotFoundException e1)
        {
            lblShow.Text = e1.ToString();
        }
        catch (Exception ex)
        {
            lblShow.Text = ex.ToString();
        }
        finally   //无论是否捕获到异常，都必须执行
        {
            lblShow.Text += "\n执行finally语句。";
            if (sr != null) sr.Close();
        }
    }
}
}
