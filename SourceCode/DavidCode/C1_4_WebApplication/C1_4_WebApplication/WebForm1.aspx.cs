using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C1_4_WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "实例1-4";
            Label lblShow = new Label
            {
                Text = "这是我的第一个Web版的C#程序。<br/>"
            };
            lblShow.Text += "请记住，C#的<b>最大特色</b>是它统一了各种应用程序的开发模式。<br/>";
            
            lblShow.Font.Size = FontUnit.Point(16);
            this.Controls.Add(lblShow);
        }
    }
}