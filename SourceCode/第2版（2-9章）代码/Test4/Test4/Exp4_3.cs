using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp4_3
{
    public partial class Exp4_3 : Form
    {
        Account account;//定义一个账户类对象
        public Exp4_3()
        {
            InitializeComponent();
        }

        private void btnCrtSavingAc_Click(object sender, EventArgs e)
        {
            //实例化储蓄卡用户账户
            account = new Account();
            int accountNo = account.CreditNo;//请将accountNo赋值为创建的账户卡号。
            string message = String.Format("创建户账户成功,用户卡号为：{0}", accountNo);
            lblShow.Text = "\n" + message + "\n";

        }       

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null)
            {
                message = "请先创建账户!";
            }
            else if (txtWithDraw.Text == "")
            {
                message = "请输入取款金额!";
            }
            else
            {
                decimal money = decimal.Parse(txtWithDraw.Text);
                account.WithDraw(money, out message);
            }
            lblShow.Text = "\n" + message + "\n";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null)
            {
                message = "请先创建账户!";
            }
            else if (txtDeposit.Text == "")
            {
                message = "请输入存款金额!";
            }
            else
            {
                decimal money = decimal.Parse(txtDeposit.Text);
                account.Deposit(money, out message);
            }
            lblShow.Text = "\n" + message + "\n";
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null)
            {
                message = "请先创建账户!";
            }
            else
            {
                message = String.Format("储蓄卡账户：{0}\n当前余额为:{1}", account.CreditNo, account.Balance);
            }
            lblShow.Text = "\n" + message + "\n";
        }

        //private void btnCrtCreditAc_Click(object sender, EventArgs e)
        //{
        //    //实例化储蓄卡用户账户
        //    account = new CreditAccount();
        //    int accountNo = account.CreditNo;//请将accountNo赋值为创建的账户卡号。
        //    string message = String.Format("创建户账户成功,用户卡号为：{0}", accountNo);
        //    ShowMessage(message);

        //}
    }
    //创建一个账户类，设计其成员变量、属性和方法
    public class Account
    {
        protected int creditNo;
        protected decimal balance;
        public Account()
        {
            Random r = new Random();
            creditNo = r.Next(100000, 499999);
            balance = 100;
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }
        public int CreditNo
        {
            get
            {
                return this.creditNo;
            }
        }
        public virtual bool WithDraw(decimal money, out string message)
        {
            if (money < 0)
            {
                message = "操作失败！\n输入金额不正确！";
                return false;
            }
            else if (balance >= money)
            {
                balance -= money;
                message = "操作成功！\n取款" + money + "元";
                return true;
            }
            else
            {
                message = "操作失败！\n余额不足！";
                return false;

            }
        }
        public virtual bool Deposit(decimal money, out string message)
        {
            if (money < 0)
            {
                message = "操作失败！\n输入金额不正确！";
                return false;
            }
            else
            {
                balance += money;
                message = "操作成功！\n存款" + money + "元";
                return true;
            }
        }

    }
}
