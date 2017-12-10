using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Test8_3
{
    public partial class Test8_3 : Form
    {
        Random r = new Random();//产生一个随机数生成器
        TemperatureWarning tw=new TemperatureWarning();

        public Test8_3()
        {
            InitializeComponent();
            //第四步：订阅事件
            //tw.OnWarning+=new TemperatureWarning.TemperatureHandler(tw_OnWarning); //订阅事件 
            tw.OnWarning += new EventHandler<TemperatureEventArgs>(tw_OnWarning); //订阅事件
            
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }
       //第三步：声明事件产生调用的方法
        private void tw_OnWarning(object sender, TemperatureEventArgs e)
        {
            if (e.Temperature < 35)
            {
                lblShow.Text = "正常";
                lblColor.BackColor = Color.Blue;
            }
            else if (e.Temperature < 37)
            {
                lblShow.Text = "高温黄色预警！";
                lblColor.BackColor = Color.Yellow;
            }
            else if (e.Temperature < 40)
            {
                lblShow.Text = "高温橙色预警！";
                lblColor.BackColor = Color.Orange;

            }
            else
            {
                lblShow.Text = "高温红色预警！";
                lblColor.BackColor = Color.Red;
            }

        }
        //每隔1秒钟激发一次该方法，用来模拟温度值的改变
        private void timer1_Tick(object sender, EventArgs e)
        {
            int nowTemp;//原来的温度值
            if (txtTemp.Text == "") nowTemp = 35;
            else           
                nowTemp = Convert.ToInt32(txtTemp.Text);
            int change = r.Next(-2, 3);//产生一个在-2到2之间的随机数
            txtTemp.Text = (change + nowTemp).ToString();//新的温度值
            //第五步：触发事件
            tw.Monitor(change + nowTemp);
            

           
        }
    }
    //第一步 定义事件相关信息类
    class TemperatureEventArgs : EventArgs
    {
        int temperature;
        public TemperatureEventArgs(int temperature)//声明构造函数
        {
            this.temperature = temperature;
        }
        public int Temperature//定义只读属性
        {
            get { return temperature; }
        }
    }

    //第二步：定义事件
    class TemperatureWarning
    {
        //2.1 声明温度预警的委托类型
        public delegate void TemperatureHandler(object sender, TemperatureEventArgs e);
        //2.2 声明温度预警事件
       // public event TemperatureHandler OnWarning;
       public event EventHandler<TemperatureEventArgs> OnWarning;
        //2.3 开始监控气温，同时发布事件
        public void Monitor(int tp)
        {
            TemperatureEventArgs e = new TemperatureEventArgs(tp);
            if (OnWarning != null)
            {
                OnWarning(this, e);
            }
            
        }
    }
}
