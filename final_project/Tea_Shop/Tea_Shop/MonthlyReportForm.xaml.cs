using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for MonthlyReportForm.xaml
    /// </summary>
    public partial class MonthlyReportForm : Window
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sda;
        public MonthlyReportForm()
        {
            InitializeComponent();
            refreshdata();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
           cmd = new SqlCommand("select SUM(price) from tbl_sale", con);
            con.Open();
            double result = (double)(cmd.ExecuteScalar());
            //MessageBox.Show(String.Format("{0}", result));
           con.Close();
            txt_TotalRevenue.Text = result.ToString();
        }

        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT * FROM tbl_sale", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataGrid_1.ItemsSource = dt.DefaultView;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
