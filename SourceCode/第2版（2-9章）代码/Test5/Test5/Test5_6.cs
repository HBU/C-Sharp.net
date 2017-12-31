using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test5_6
{
    public partial class Test5_6 : Form
    {
        public Test5_6()
        {
            InitializeComponent();
        }

        private void btnMp3_Click(object sender, EventArgs e)
        {
            //Mp3 m = new Mp3();
            //if (m is IUsb)  //能安全转换，表达式为true，下面语句将执行
            //{
            //    IUsb iu = (IUsb)m;
            //    lblShow.Text = iu.TransData("计算机", "MP3设备");
            //}
            //if (m is IBluetooth)   //不能安全转换，表达式为假，下面语句将不会执行
            //{
            //    IBluetooth ib = (IBluetooth)m;
            //    lblShow.Text = ib.TransData("计算机", "蓝牙设备");
            //}

            Mp3 m = new Mp3();
            IUsb iu = m as IUsb;
            if (iu!=null)  //能安全转换，表达式为true，下面语句将执行
            {
               lblShow.Text = iu.TransData("计算机", "MP3设备");
            }
            IBluetooth ib = m as IBluetooth;
            if (ib!=null)   //不能安全转换，表达式为假，下面语句将不会执行
            {
                lblShow.Text = ib.TransData("计算机", "蓝牙设备");
            }

            //lblShow.Text = iu.TransData("计算机", "MP3设备");
           // lblShow.Text = m.TransData("计算机", "MP3设备");
            
        }

        private void btnMobile_Click(object sender, EventArgs e)
        {
            Mobile mob = new Mobile();
            //if (mob is Phone)
            //{
            //    Phone phi = (Phone)mob; 
            //}
            //Phone pha = mob as Phone;

            IUsb iu = mob as IUsb;
            if (iu != null) lblShow.Text = iu.TransData("计算机", "手机");
            IBluetooth ib = mob as IBluetooth;
            if (ib != null) lblShow.Text += "\n" + ib.TransData("手机", "计算机");
            lblShow.Text+="\n"+mob.Call("父亲");

        }
    }
    interface IUsb
    {
        int MaxSpeed { get; }
        string TransData(string from, string to);
    }
    interface IBluetooth
    {
        int MaxSpeed { get; }
        string TransData(string from, string to);
    }
    interface IMp3 : IUsb, IBluetooth
    {
        string Play(string fileName);
    }
    public class Mp3:IUsb
    {
        public int MaxSpeed
        {
            get { return 480; }
        }

        public string TransData(string from, string to)
        {
            return string.Format("数据转输：从{0}到{1}", from, to);
        }

    }
    public abstract class Phone
    {
        public abstract string Call(string name);
    }
    public class Mobile : Phone,IUsb, IBluetooth
    {
        int IUsb.MaxSpeed
        {
            get { return 480; }
        }

        string IUsb.TransData(string from, string to)
        {
             return string.Format("USB数据转输：从{0}到{1}", from, to);
        }

        int IBluetooth.MaxSpeed
        {
            get { return 64; }
        }

        string IBluetooth.TransData(string from, string to)
        {
            return string.Format("Bluetooth数据转输：从{0}到{1}", from, to);
        }
        public override string Call(string name)
        {
            return string.Format("和{0}通话中....",name);
        }

      
    }
}
