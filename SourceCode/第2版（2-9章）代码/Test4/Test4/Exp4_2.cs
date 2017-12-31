using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp4_2
{
    public partial class Exp4_2 : Form
    {
        Time t ;
        public Exp4_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            t.AddSecond();
            textBox1.Text = t.Hour.ToString();
            textBox2.Text = t.Minute.ToString();
            textBox3.Text = t.Second.ToString();
            
        }

        private void 实训4_2_Load(object sender, EventArgs e)
        {
            t = new Time();
            textBox1.Text = t.Hour.ToString();
            textBox2.Text = t.Minute.ToString();
            textBox3.Text = t.Second.ToString();
        }
    }
    class Time
    {
        int hour;
        int minute;
        int second;
        public Time()
        {
            hour = System.DateTime.Now.Hour;
            minute = System.DateTime.Now.Minute;
            second = System.DateTime.Now.Second;
        }
        public Time(int h, int m, int s)
        {
            hour = h; minute = m; second = s;
        }
        public int Hour
        {
            get { return hour; }
          }
        public int Minute
        {
            get { return minute; }
            
        }
        public int Second
        {
            get { return second; }
        }
        public void AddSecond()
        {
            second++;
            if (second >= 60)
            {
                second = second % 60;
                minute++;
            }
            if (minute >= 60)
            {
                minute = minute % 60;
                hour++; 
            }

           
        }
        
        
    }
}
