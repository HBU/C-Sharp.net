using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3
{
    
    public partial class Form1 : Form
    {
        public static string resultSring="";
        public Form1()
        {
            InitializeComponent();
        }
         
        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = OpenCSV(@".\trainingdata.csv");//DMA\ID3\ID3\bin\Debug\trainingdata.csv
            dataGridView1.DataSource = dataTable;
        }

        public static DataTable OpenCSV(string filePath)
        {
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            //记录每次读取的一行记录
            string strLine = "";
            //记录每行记录中的各字段内容
            string[] aryLine;
            //标示列数
            int columnCount = 0;
            //标示是否是读取的第一行
            bool IsFirst = true;
            //逐行读取CSV中的数据
            while ((strLine = sr.ReadLine()) != null)
            {
                aryLine = strLine.Split(';'); //  需要注意文件里的分隔符是" ," 还是 "; ",错了就不好用了。2019.6.5 BY David。
                if (IsFirst == true)
                {
                    IsFirst = false;
                    columnCount = aryLine.Length;
                    for (int i = 0; i < columnCount; i++)
                    {
                        DataColumn dc = new DataColumn(aryLine[i]);
                        dt.Columns.Add(dc);
                    }
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < columnCount; j++)
                    {
                        dr[j] = aryLine[j];
                    }
                    dt.Rows.Add(dr);
                }
            }
            sr.Close();
            fs.Close();
            return dt;
        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
            DataTable data = OpenCSV(@".\trainingdata.csv");
            richTextBox1.Text = "";
            resultSring = "";
            var decisionTree = new Tree();
            
            decisionTree.Root = Tree.Learn(data, "");

            
            for (var i = 0; i < data.Columns.Count - 1; i++)
                {
                        Print(decisionTree.Root, decisionTree.Root.Name.ToUpper());
                        // MessageBox.Show(""+ decisionTree.Root+"#"+ decisionTree.Root.Name.ToUpper());
                        //Result += resultSring + "\n";
                }
            richTextBox1.Text = resultSring;
            MessageBox.Show("Finish !");
        }

        public static void Print(TreeNode node, string result)
        {
            //MessageBox.Show("result :"+ result);
            if (node?.ChildNodes == null || node.ChildNodes.Count == 0)
            {
                var seperatedResult = result.Split(' ');

                foreach (var item in seperatedResult)
                {
                    if (item.Equals(seperatedResult[0]))
                    {
                        //Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (item.Equals("--") || item.Equals("-->"))
                    {
                        // empty if but better than checking at .ToUpper() and .ToLower() if
                    }
                    else if (item.Equals("YES") || item.Equals("NO"))
                    {
                        //Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (item.ToUpper().Equals(item))
                    {
                        //Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        //Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write($"{item} ");
                    
                    resultSring += $"{item} ";
                    //Console.ResetColor();

                }

                Console.WriteLine();
                resultSring += "\n";

                return;
            }

            foreach (var child in node.ChildNodes)
            {
                Print(child, result + " -- " + child.Edge.ToLower() + " --> " + child.Name.ToUpper());
            }
        }
    }
}
