using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DatabaseTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString.ToString();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = "select * from Student",
                Connection = sqlConnection,
                CommandType = CommandType.Text
            };
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Stu");
                DataTable dt = dataSet.Tables["Stu"];
                this.DataGridView.ItemsSource = dt.DefaultView;
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("haha");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = "select * from Student where Sname = '"+TextBoxName.Text.Trim()+"'",
                Connection = sqlConnection,
                CommandType = CommandType.Text
            };
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Stu");
                DataTable dt = dataSet.Tables["Stu"];
                this.DataGridView.ItemsSource = dt.DefaultView;
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

    }
}
