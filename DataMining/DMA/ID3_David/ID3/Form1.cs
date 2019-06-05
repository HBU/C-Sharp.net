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

    //ID3详解 https://blog.csdn.net/qq_36330643/article/details/77415451

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
         
        
        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            DataTable dataTable = OpenCSV(@".\trainingdata.csv");//载入数据
            
            int i = 0;
            int rowsCount = dataTable.Rows.Count;
            int colsCount = dataTable.Columns.Count;
            string[,] da = new string[rowsCount, colsCount];
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                int j = 0;
                foreach (System.Data.DataColumn column in dataTable.Columns)
                {
                    da[i, j] = row[column.ColumnName].ToString().Trim();
                    j = j + 1;
                }
                i = i + 1;
            }

            var names = new string[] { "Outlook", "Temperatur", "Humidity", "Wind", "Class: NeedUmbrella" };
            var tree = new DecisionTreeID3<string>(da, names, new string[] { "Yes", "No" });
            tree.Learn();
            richTextBox1.Text = resultSring;
            MessageBox.Show("Build Tree Finished");
        }

        public class DecisionTreeID3<T> where T : IEquatable<T>
        {
            T[,] Data;
            string[] Names;
            int Category;
            T[] CategoryLabels;
            DecisionTreeNode<T> Root;
            public DecisionTreeID3(T[,] data, string[] names, T[] categoryLabels)
            {
                Data = data;
                Names = names;
                Category = data.GetLength(1) - 1;//类别变量需要放在最后一列
                CategoryLabels = categoryLabels;
            }
            public void Learn()
            {
                int nRows = Data.GetLength(0);
                int nCols = Data.GetLength(1);
                int[] rows = new int[nRows];
                int[] cols = new int[nCols];
                for (int i = 0; i < nRows; i++) rows[i] = i;
                for (int i = 0; i < nCols; i++) cols[i] = i;
                Root = new DecisionTreeNode<T>(-1, default(T));
                Learn(rows, cols, Root);//
                DisplayNode(Root);
            }
            public void DisplayNode(DecisionTreeNode<T> Node, int depth = 0)//显示节点
            {
                if (Node.Label != -1)
                {
                    //Console.WriteLine("{0} {1}: {2}", new string('-', depth * 3), Names[Node.Label], Node.Value);
                    resultSring += new string('-', depth * 3)+ Names[Node.Label]+"-->"+ Node.Value+"\n";
                }
                foreach (var item in Node.Children)
                    DisplayNode(item, depth + 1);//递归
            }
            private void Learn(int[] pnRows, int[] pnCols, DecisionTreeNode<T> Root)// 算法核心
            {
                var categoryValues = GetAttribute(Data, Category, pnRows);
                var categoryCount = categoryValues.Distinct().Count();
                if (categoryCount == 1)
                {
                    var node = new DecisionTreeNode<T>(Category, categoryValues.First());
                    Root.Children.Add(node);
                }
                else
                {
                    if (pnRows.Length == 0) return;
                        else if (pnCols.Length == 1)
                        {
                            //投票～ //多数票表决制
                            var Vote = categoryValues.GroupBy(i => i).OrderBy(i => i.Count()).First();
                            var node = new DecisionTreeNode<T>(Category, Vote.First());
                            Root.Children.Add(node);
                        }
                        else
                        {
                            var maxCol = MaxEntropy(pnRows, pnCols);//最大熵
                            var attributes = GetAttribute(Data, maxCol, pnRows).Distinct();
                            string currentPrefix = Names[maxCol];
                            foreach (var attr in attributes)
                            {
                                int[] rows = pnRows.Where(irow => Data[irow, maxCol].Equals(attr)).ToArray();
                                int[] cols = pnCols.Where(i => i != maxCol).ToArray();
                                var node = new DecisionTreeNode<T>(maxCol, attr);
                                Root.Children.Add(node);
                                Learn(rows, cols, node);//递归生成决策树
                            }
                        }
                }
            }
            public double AttributeInfo(int attrCol, int[] pnRows)
            {
                var tuples = AttributeCount(attrCol, pnRows);
                var sum = (double)pnRows.Length;
                double Entropy = 0.0;
                foreach (var tuple in tuples)
                {
                    int[] count = new int[CategoryLabels.Length];
                    foreach (var irow in pnRows)
                        if (Data[irow, attrCol].Equals(tuple.Item1))
                        {
                            int index = Array.IndexOf(CategoryLabels, Data[irow, Category]);
                            count[index]++;//目前仅支持类别变量在最后一列
                        }
                    double k = 0.0;
                    for (int i = 0; i < count.Length; i++)
                    {
                        double frequency = count[i] / (double)tuple.Item2;
                        double t = -frequency * Log2(frequency);
                        k += t;
                    }
                    double freq = tuple.Item2 / sum;
                    Entropy += freq * k;
                }
                return Entropy;
            }
            public double CategoryInfo(int[] pnRows)
            {
                var tuples = AttributeCount(Category, pnRows);
                var sum = (double)pnRows.Length;
                double Entropy = 0.0;
                foreach (var tuple in tuples)
                {
                    double frequency = tuple.Item2 / sum;
                    double t = -frequency * Log2(frequency);
                    Entropy += t;
                }
                return Entropy;
            }
            private static IEnumerable<T> GetAttribute(T[,] data, int col, int[] pnRows)
            {
                foreach (var irow in pnRows)
                    yield return data[irow, col];
            }
            private static double Log2(double x)
            {
                return x == 0.0 ? 0.0 : Math.Log(x, 2.0);
            }
            public int MaxEntropy(int[] pnRows, int[] pnCols)
            {
                double cateEntropy = CategoryInfo(pnRows);
                int maxAttr = 0;
                double max = double.MinValue;
                foreach (var icol in pnCols)
                    if (icol != Category)
                    {
                        double Gain = cateEntropy - AttributeInfo(icol, pnRows);
                        if (max < Gain)
                        {
                            max = Gain;
                            maxAttr = icol;
                        }
                    }
                MessageBox.Show("MaxEntropy:" + maxAttr);
                return maxAttr;
            }
            public IEnumerable<Tuple<T, int>> AttributeCount(int col, int[] pnRows)
            {
                var tuples = from n in GetAttribute(Data, col, pnRows)
                             group n by n into i
                             select Tuple.Create(i.First(), i.Count());
                return tuples;
            }
        }
        public sealed class DecisionTreeNode<T>
        {
            public int Label { get; set; }
            public T Value { get; set; }
            public List<DecisionTreeNode<T>> Children { get; set; }
            public DecisionTreeNode(int label, T value)
            {
                Label = label;
                Value = value;
                Children = new List<DecisionTreeNode<T>>();
            }
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
    }
}
