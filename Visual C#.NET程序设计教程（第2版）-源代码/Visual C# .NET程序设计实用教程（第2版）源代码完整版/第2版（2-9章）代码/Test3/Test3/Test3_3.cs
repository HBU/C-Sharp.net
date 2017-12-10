using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test3
{
    public partial class Test3_3 : Form
    {
        public Test3_3()
        {
            InitializeComponent();
        }

    private void button1_Click(object sender, EventArgs e)
    {
        double score = Convert.ToDouble(txtScore.Text);
        switch ((int)(score / 10))
        {
            case 10:
            case 9:
                lblShow.Text = "您的成绩为：优"; break;
            case 8:
                lblShow.Text = "您的成绩为：良"; break;
            case 7:
                lblShow.Text = "您的成绩为：中"; break;
            case 6:
                lblShow.Text = "您的成绩为：及格"; break;
            default:
                lblShow.Text = "您的成绩为：不及格"; break;

        }
        //if (score >= 90) lblShow.Text = "您的成绩为：优";
        //else if (score >= 80 && score < 90) lblShow.Text = "您的成绩为：良";
        //else if (score >= 70 && score < 80) lblShow.Text = "您的成绩为：中";
        //else if (score >= 60 && score < 70) lblShow.Text = "您的成绩为：及格";
        //else lblShow.Text = "您的成绩为：不及格";
    }
    }
}
