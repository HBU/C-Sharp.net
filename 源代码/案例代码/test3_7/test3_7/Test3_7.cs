using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test3_7
{
public partial class Test3_7 : Form
{
    //声明结构体
    struct Contacter
    {
        public string name;
        public string telphone;
    }
    //声明结构体数组，用于保存联系人信息
    Contacter[] persons= new Contacter[10];
    int i=0;           //记录已添加的联系人数
    public Test3_7()
    {
        InitializeComponent();
    }
    //将用户输入保存到第i个结构体数组元素中
    private void btnAdd_Click(object sender, EventArgs e)
    {
        persons[i].name = txtName.Text;
        persons[i].telphone = txtTel.Text;
        i++;
        lblShow.Text = "已成功添加一个联系人！";
    }
    //查找指定联系人，并显示其电话号码
    private void btnSearch_Click(object sender, EventArgs e)
    {
        bool isSearched = false;   //定义查找是否成功的标志变量，默认为查无此人
        foreach (Contacter c in persons)
        {
            if (c.name == txtSearch.Text.Trim())
            {
                isSearched = true;  //修改标志变量，表示查找成功
                lblShow.Text = "查找成功！此人电话号码为：" + c.telphone;
            }
        }
        if (!isSearched)
            lblShow.Text = "查无此人！";
    }
}
}
