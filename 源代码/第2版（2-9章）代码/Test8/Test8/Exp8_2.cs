using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp8_2
{
    public partial class Exp8_2 : Form
    {
        private Stock myStock;
        Random r ;
        private EventHandler<StockEventArgs> myStock_OnStockFall;
        
        public Exp8_2()
        {
            InitializeComponent();
            int price = Convert.ToInt32(txtStartPrice.Text);
            myStock = new Stock(price);
            r = new Random();//产生一个随机数生成器
        }

        private void btnOpened_Click(object sender, EventArgs e)
        {
            
            myStock.OnStockChange += new EventHandler<StockEventArgs>(Change);
            timer1.Enabled = true;
        }
        private void btnBuying_Click(object sender, EventArgs e)
        {
            myStock.OnStockFall += new EventHandler<StockEventArgs>(Fall);
        }
        private void btnSelling_Click(object sender, EventArgs e)
        {
            myStock.OnStockRise+=new EventHandler<StockEventArgs>(Rise);
        }
        void Change(object sender, StockEventArgs e)
        {
            this.txtCurPrice.Text = myStock.Price.ToString();
            rtbMessages.AppendText( "\n当前股价：" + myStock.Price);
            
        }
        void Fall(object sender, StockEventArgs e)
        {
            int buy = Convert.ToInt32(txtBuy.Text);
            if (myStock.Price < buy)
            {
                rtbMessages.Text += "\n+买入，买入价：" + myStock.Price;
                myStock.OnStockFall -= new EventHandler<StockEventArgs>(Fall);
                txtBuy.Text = "";
            }

        }
        void Rise(object sender, StockEventArgs e)
        {
            int sell = Convert.ToInt32(txtSell.Text);
            if (myStock.Price > sell)
            {
                rtbMessages.Text += "\n-卖出，卖出价：" + myStock.Price;
                myStock.OnStockRise -= new EventHandler<StockEventArgs>(Rise);
                txtSell.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nowPrice;//原来的股票价格
            if (txtCurPrice.Text == "") nowPrice = Convert.ToInt32(txtStartPrice.Text);
            else
                nowPrice = Convert.ToInt32(txtCurPrice.Text);
            int change = r.Next(-3, 4);//产生一个在-3到3之间的随机数           
            //更改股票价格：触发事件
            myStock.Price = nowPrice + change; //新的股票价格           
        }
       

       

        
    }
    //定义事件相关信息类
    class StockEventArgs : EventArgs
    {
        int stockPrice;
        public StockEventArgs(int stockPrice)//声明构造函数
        {
            this.stockPrice = stockPrice;
        }
        public int StockPrice//定义只读属性
        {
            get { return stockPrice; }
        }
    }
    class Stock
    {
        //声明事件
        public event EventHandler<StockEventArgs> OnStockChange;
        public event EventHandler<StockEventArgs> OnStockRise;
        public event EventHandler<StockEventArgs> OnStockFall;
        private int stockPrice;
        public Stock(int price)
        {
            stockPrice = price;
        }
        //当股票价格改变，触发事件
        public int Price
        {
            set
            {
                decimal oldPrice = stockPrice;
                stockPrice = value;
                if (OnStockChange != null && (oldPrice != value))
                {
                    OnStockChange(this, new StockEventArgs(stockPrice));
                }
                if ((OnStockFall != null) && (oldPrice > value))
                {
                    OnStockFall(this, new StockEventArgs(stockPrice));
                }
                else if ((OnStockRise != null) && (oldPrice < value))
                {
                    OnStockRise(this, new StockEventArgs(stockPrice));
                }
               
            }
            get
            {
                return stockPrice;
            }
        }

       
    }
}
