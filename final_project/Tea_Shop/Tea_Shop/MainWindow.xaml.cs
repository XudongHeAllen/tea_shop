using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Tea_Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd;

        private void btn_buy1_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Thank you for buying!");
            //get info from db
            cmd = new SqlCommand("select inventory from tbl_product where product_id = 1", con);
            con.Open();
            int result = (Int32)(cmd.ExecuteScalar());
            //result -= 1;
            MessageBox.Show(String.Format("{0}", result));
            con.Close();
            //mius from tbl_inventory
            cmd = new SqlCommand("update tbl_product SET [inventory] = @inventory Where product_id = 1", con);
            con.Open();
            cmd.Parameters.AddWithValue("@inventory", result - 1);
            cmd.ExecuteNonQuery();
            con.Close();
            //add into tbl_sales
            cmd = new SqlCommand("insert into tbl_sale([name],[price]) values (@name,@price)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", "Black tea");
            cmd.Parameters.AddWithValue("@price", "1.80");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            //navigate into login_form
            Window1 loginPage = new Window1();
            loginPage.Show();
            Hide();
        }

        private void btn_buy2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for buying!");
            //get info from db
            cmd = new SqlCommand("select inventory from tbl_product where product_id = 2", con);
            con.Open();
            int result = (Int32)(cmd.ExecuteScalar());
            //result -= 1;
            MessageBox.Show(String.Format("{0}", result));
            con.Close();
            //mius from tbl_inventory
            cmd = new SqlCommand("update tbl_product SET [inventory] = @inventory Where product_id = 2", con);
            con.Open();
            cmd.Parameters.AddWithValue("@inventory", result - 1);
            cmd.ExecuteNonQuery();
            con.Close();
            //add into tbl_sales
            cmd = new SqlCommand("insert into tbl_sale([name],[price]) values (@name,@price)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", "Green Tea");
            cmd.Parameters.AddWithValue("@price", "1.80");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_buy3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for buying!");
            //get info from db
            cmd = new SqlCommand("select inventory from tbl_product where product_id = 3", con);
            con.Open();
            int result = (Int32)(cmd.ExecuteScalar());
            //result -= 1;
            MessageBox.Show(String.Format("{0}", result));
            con.Close();
            //mius from tbl_inventory
            cmd = new SqlCommand("update tbl_product SET [inventory] = @inventory Where product_id = 3", con);
            con.Open();
            cmd.Parameters.AddWithValue("@inventory", result - 1);
            cmd.ExecuteNonQuery();
            con.Close();
            //add into tbl_sales
            cmd = new SqlCommand("insert into tbl_sale([name],[price]) values (@name,@price)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", "Milk Tea");
            cmd.Parameters.AddWithValue("@price", "1.95");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_buy4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for buying!");
            //get info from db
            cmd = new SqlCommand("select inventory from tbl_product where product_id = 4", con);
            con.Open();
            int result = (Int32)(cmd.ExecuteScalar());
            //result -= 1;
            MessageBox.Show(String.Format("{0}", result));
            con.Close();
            //mius from tbl_inventory
            cmd = new SqlCommand("update tbl_product SET [inventory] = @inventory Where product_id = 4", con);
            con.Open();
            cmd.Parameters.AddWithValue("@inventory", result - 1);
            cmd.ExecuteNonQuery();
            con.Close();
            //add into tbl_sales
            cmd = new SqlCommand("insert into tbl_sale([name],[price]) values (@name,@price)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", "Espresso");
            cmd.Parameters.AddWithValue("@price", "2.30");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_buy5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for buying!");
            //get info from db
            cmd = new SqlCommand("select inventory from tbl_product where product_id = 5", con);
            con.Open();
            int result = (Int32)(cmd.ExecuteScalar());
            //result -= 1;
            MessageBox.Show(String.Format("{0}", result));
            con.Close();
            //mius from tbl_inventory
            cmd = new SqlCommand("update tbl_product SET [inventory] = @inventory Where product_id = 5", con);
            con.Open();
            cmd.Parameters.AddWithValue("@inventory", result - 1);
            cmd.ExecuteNonQuery();
            con.Close();
            //add into tbl_sales
            cmd = new SqlCommand("insert into tbl_sale([name],[price]) values (@name,@price)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", "Americano");
            cmd.Parameters.AddWithValue("@price", "2.35");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_buy6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for buying!");
            //get info from db
            cmd = new SqlCommand("select inventory from tbl_product where product_id = 6", con);
            con.Open();
            int result = (Int32)(cmd.ExecuteScalar());
            //result -= 1;
            MessageBox.Show(String.Format("{0}", result));
            con.Close();
            //mius from tbl_inventory
            cmd = new SqlCommand("update tbl_product SET [inventory] = @inventory Where product_id = 6", con);
            con.Open();
            cmd.Parameters.AddWithValue("@inventory", result - 1);
            cmd.ExecuteNonQuery();
            con.Close();
            //add into tbl_sales
            cmd = new SqlCommand("insert into tbl_sale([name],[price]) values (@name,@price)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", "Cappucino");
            cmd.Parameters.AddWithValue("@price", "2.75");
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
