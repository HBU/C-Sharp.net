﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3_6
{
public partial class Test3_6 : Form
{
    public Test3_6()
    {
        InitializeComponent();
    }

    private void Test3_6_Load(object sender, EventArgs e)
    {
        int i;
        double t,s1, s2;
        s1 = t = 0.01;             //百万富翁第一天给陌生人的钱为1分
        s2 = 100000;            //陌生人第一天给百万富翁的钱为十万元
        for (i = 2; i <= 30; i++)
        {
            t = t * 2;          //百万富翁第i天给陌生人的钱
            s1 = s1 + t;        //百万富翁第i天后共给陌生人的钱
            s2 = s2 + 100000;   //陌生人第i天后共百万富翁的钱
        }
        lblShow.Text =String.Format("百万富翁给陌生人{0:N2}元。\n陌生人给百万富翁{1:N2}元。",s1,s2);
    }
}
}
