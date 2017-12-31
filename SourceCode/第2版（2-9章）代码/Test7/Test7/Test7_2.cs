using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test7_2
{
    public partial class Test7_2 : Form
    {
        public Test7_2()
        {
            InitializeComponent();
        }

    public int Factorial(int n)
    {

        int result = 1, i = 1;
        while (i <= n)
        {
            result *= i;
            i++;
        }
        return result;
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            int n = Convert.ToInt32(txtNum.Text);
            int result = Factorial(n);
            txtResult.Text = result.ToString();
        }
        catch (System.FormatException ex)
        {
            lblShow.Text = ex.Message;
        }
        catch (System.OverflowException ex)
        {
            lblShow.Text = ex.Message;
        }
        catch(System.Exception ex)
        {
            lblShow.Text = ex.Message;
        }
    }
    }
}
