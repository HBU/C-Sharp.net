using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test7_5
{
    public partial class Test7_5 : Form
    {
        public Test7_5()
        {
            InitializeComponent();
        }

        private void btnChackEmail_Click(object sender, EventArgs e)
        {
            SaveEmail saveEmail = new SaveEmail();
            try
            {
                if (saveEmail.ChackEmail(txtEmail.Text))
                {
                    lblShow.Text="检查成功";
                }
            }
            catch (EmailErrorExcetion ex)
            {
                lblShow.Text = ex.Message;
            }

        }
    }
    public class EmailErrorExcetion :Exception
    {
        public EmailErrorExcetion() { }
        public EmailErrorExcetion(string message) : base(message){ }
        public EmailErrorExcetion(string message, System.Exception innerException) : base(message, innerException) { }
        public override string Message//Message属性的重载
        {
            get
            {
                return "Email格式不正确:" + base.Message;
            }
        }
    }
    public class SaveEmail
    {
        public bool ChackEmail(string email)
        {
            string[] strSign=email.Split('@');
             //如果输入的Email不是被“@”字符分割成两段，则抛出Email错误异常
            if(strSign.Length !=2||strSign[0].Length==0||strSign[1].Length==0)
            {
                throw new EmailErrorExcetion("@符号不正确!");
            }
            else
            {
                int index=strSign[1].IndexOf(".");
                //查找被“@”字符分成的两段的后一段中“.”字符的位置，没有“.” 
                //或者“.”字符是第一个或最后一个字符，则抛出EmailErrorException异常
                if(index<=0||index>=strSign[1].Length-1)
                {
                    throw new EmailErrorExcetion(".符号不正确");
                }
            }
            return true;
        }
    }


}
