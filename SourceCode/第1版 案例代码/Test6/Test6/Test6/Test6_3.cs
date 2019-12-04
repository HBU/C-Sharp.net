using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
namespace Test6
{
    public partial class Test6_3 : Form
    {
        Album friends = new Album(3); // 创建一个容量为 3 的相册
        public Test6_3()
        {
            InitializeComponent();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text)-1;//索引从0开始
            Photo pho = new Photo(txtTitle.Text); // 创建1张照片
            friends[index] = pho; // 向相册加载照片
            lblShow.Text = string.Format("照片添加成功！"); 
            //第一次学走路
            //小学毕业
            //进入大学校门
         

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text)-1;
            Photo pho = friends[index];//按索引检索
            if (pho != null)
                lblShow.Text = string.Format("第{0}张照片的标题是：{1}", index+1, pho.Title);
            else lblShow.Text = string.Format("没有第{0}张照片！", index+1); 

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Photo pho = friends[txtTitle.Text];// 按名称检索
            if (pho != null)
                lblShow.Text = string.Format("找到标题为：{0} 的照片！",  pho.Title);
            else lblShow.Text = string.Format("没有找到标题为：{0} 的照片", txtTitle.Text); 

        }
    }
    class Photo//定义一个照片类
    {
        string _title;
        public Photo(string title)
        {
            this._title = title;
        }
        public string Title  //只读属性，返回照片标题
        {
            get
            {
                return _title;
            }
        }
    }
    class Album  //定义一个相册类
	{
		
		Photo[] photos;// 该数组用于存放照片
        public Album(int capacity) //构造函数，初始化指定大小的Photo数组
		{
			photos = new Photo[capacity];
		}
        public Photo this[int index] //带有 int参数的Photo读/写索引器
        {
            get
            {
                
                if (index < 0 || index >= photos.Length)// 验证索引范围
                {
                    return null; // 使用 null 指示失败
                }
                return photos[index]; // 对于有效索引，返回请求的照片
            }
            set
            {
                if (index < 0 || index >= photos.Length)
                {
                   return;
                }
                photos[index] = value;
            }
        }
        public Photo this[string title]//带有string参数的Photo只读索引器
        {
            get
            {                
                foreach (Photo p in photos)// 遍历数组中的所有照片
                {
                    
                    if (p.Title == title)// 将照片中的标题与索引器参数进行比较
                        return p;
                }               
                
                return null;// 使用 null 指示失败
            }
        }
    }

    public interface IAddress
    {
        string this[int index] { get; set; }  	//声明索引器
        string Address { get; set; }       		//声明属性
        string Answer();              		//声明方法
    }
    



}
