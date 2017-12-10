using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
namespace Test13_8
{
    class FtpHelper              //定义FTP助手
    {
        FtpWebRequest request;   //FTP请求对象，可远程访问FTP服务器
        public FtpHelper()       //构造函数
        {
            request = null;
        }
        //以登录方式连接FTP服务器
        public bool ConnectionToFtp(string uri, string user, string pwd)
        {
            try
            {
                request = (FtpWebRequest)WebRequest.Create(uri);//创建WebRequest实例
                request.Credentials = new NetworkCredential(user, pwd);//设置与FTP服务器通信的凭证
                return true;
            }
            catch
            {
                return false;
            }
        }
        //以匿名方式连接FTP服务器
        public bool ConnectionToFtp(string uri)
        {
            try
            {
                request = (FtpWebRequest)WebRequest.Create(new Uri(uri));//创建WebRequest实例
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string[] getFilesList()   //返回FTP服务器的文件列表
        {
            Encoding encoding = System.Text.Encoding.GetEncoding("GB2312");//获取一个能够使用GB2312进行编码/解码的Encoding的对象
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;//设置要发送到FTP服务器的命令是获取文件列表
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();//获取包含从FTP服务器上发送的响应数据的流
            StreamReader reader = new StreamReader(stream, encoding);//用指定的编码和指定的流初始化StreamReader对象
            string content = reader.ReadToEnd();
            //返回的内容形如："-rwx------ 1 user group         567808 Dec 09 2006 ch1.ppt\r\n"
            string[] files = content.Split('\n');
            for (int i = 0; i < files.Length; i++)
            {
                int start = files[i].LastIndexOf(' ');
                files[i] = files[i].Substring(start + 1);//只保留文件名
            }
            reader.Close();
            stream.Close();
            response.Close();
            return files;
        }

        public bool DownLoad(string path)   //下载文件
        {
            try
            {
                request.Method = WebRequestMethods.Ftp.DownloadFile;//设置要发送到FTP服务器的命令是下载文件
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream downStream = response.GetResponseStream();//获取包含从FTP服务器上发送的响应数据的流
                Stream outStream = File.OpenWrite(path);//打开文件以便写入文件
                byte[] buffer = new byte[1024];
                int size = 0;
                while ((size = downStream.Read(buffer, 0, 1024)) > 0) //每次读取1024个字节并写入
                {
                    outStream.Write(buffer, 0, size); //将已下载的字节写入文件
                }
                downStream.Close();
                outStream.Close();
                response.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool FileUp(string path)   //上传指定的文件
        {
            try
            {
                request.Method = WebRequestMethods.Ftp.UploadFile;
                StreamReader inStream = new StreamReader(path);  //将磁盘文件打开，准备上传
                byte[] contents = Encoding.UTF8.GetBytes(inStream.ReadToEnd());  //读磁盘文件
                inStream.Close();                                //关闭磁盘文件
                Stream upStream = request.GetRequestStream();    //获得向FTP服务器上传的流
                upStream.Write(contents, 0, contents.Length);    //上传数据
                upStream.Close();                                //结束上传
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
