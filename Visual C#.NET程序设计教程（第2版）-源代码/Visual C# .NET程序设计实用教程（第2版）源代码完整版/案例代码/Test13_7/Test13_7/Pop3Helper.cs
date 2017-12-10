using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Test13_7
{
    public class Pop3Helper
    {
        string _pop3server;
        string _user;
        int _port;
        string _pwd;

        public TcpClient _server;
        public NetworkStream _netStream;
        public StreamReader _reader;
        public string _data;
        public byte[] _charData;
        public string _CRLF = "\r\n";

        private string _log;
        public string LogMSG
        {
            get { return _log; }
        }

        public Pop3Helper(string server, int port, string user, string pwd)
        {
            _pop3server = server;
            _port = port;
            _user = user;
            _pwd = pwd;
        }

        public void Connect()
        {
            //create a tcp connection
            _server = new TcpClient(_pop3server, _port);

            //prepare 
            _netStream = _server.GetStream();
            _reader = new StreamReader(_server.GetStream());
            if (!CheckResult(_reader.ReadLine()))
                throw new Exception("连接失败");

            //login
            _data = "USER " + this._user + _CRLF;
            _charData = System.Text.Encoding.ASCII.GetBytes(_data.ToCharArray());
            _netStream.Write(_charData, 0, _charData.Length);
            if (!CheckResult(_reader.ReadLine()))
                throw new Exception("用户名错误");

            _data = "PASS " + this._pwd + _CRLF;
            _charData = System.Text.Encoding.ASCII.GetBytes(_data.ToCharArray());
            _netStream.Write(_charData, 0, _charData.Length);
            if (!CheckResult(_reader.ReadLine()))
                throw new Exception("口令错误");
        }

        public int GetMailCount()
        {
            try
            {
                _data = "STAT" + _CRLF;
                _charData = System.Text.Encoding.ASCII.GetBytes(_data.ToCharArray());
                _netStream.Write(_charData, 0, _charData.Length);
                string resp = _reader.ReadLine();
                string[] tokens = resp.Split(new char[] { ' ' });
                return Convert.ToInt32(tokens[1]);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public string GetMail(int id)
        {
            string line;
            string content = "";
            try
            {
                //get by id
                _data = "RETR " + id + _CRLF;
                _charData = System.Text.Encoding.ASCII.GetBytes(_data.ToCharArray());
                _netStream.Write(_charData, 0, _charData.Length);
                line = _reader.ReadLine();

                if (line[0] != '-')
                {
                    //end with '.'
                    while (line != ".")
                    {
                        line = _reader.ReadLine();
                        content += line + "\r\n";
                    }
                }
                return content;
            }

            catch (Exception err)
            {
                Log(err.Message);
                return "Error";
            }
        }
        public void DeleteMail(int id)
        {
            _data = "DELE " + id + _CRLF;
            _charData = System.Text.Encoding.ASCII.GetBytes(_data.ToCharArray());
            _netStream.Write(_charData, 0, _charData.Length);
            if (!CheckResult(_reader.ReadLine()))
                throw new Exception("Delete Error");
        }

        public void Close()
        {

            _data = "QUIT" + _CRLF;
            _charData = System.Text.Encoding.ASCII.GetBytes(_data.ToCharArray());
            _netStream.Write(_charData, 0, _charData.Length);

            //close 
            _netStream.Close();
            _reader.Close();
        }

        private bool CheckResult(string reply)
        {
            Log(reply);
            if (reply.IndexOf("+OK") > -1)
                return true;
            else
                return false;
        }
        private void Log(string msg)
        {
            _log += msg + "\r\n";
        }
    }
}
