using System;
using System.Windows;
using System.Windows.Controls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Tea_Shop;

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for ProductManagerForm.xaml
    /// This form was created by Hung-200452314
    /// </summary>
    public partial class ProductManagerForm : Window
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sda;
        int product_id; // check product_id of gridview and DB.
        public ProductManagerForm()
        {
            InitializeComponent();
            LoadData();
            RefreshTextFields();
            btn_Update.IsEnabled = false;
            btn_Delete.IsEnabled = false;
            btn_Refresh.IsEnabled = false;
        }

        private void LoadData()
        {
            cmd = new SqlCommand("SELECT * FROM tbl_product", sqlCon);
            sqlCon.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            DataGridView1.ItemsSource = dt.DefaultView;
        }

        private void RefreshTextFields()
        {
            txt_Type.Text = "";
            txt_Price.Text = "";
            txt_Inventory.Text = "";
            txt_Description.Text = "";
        }



        private void btn_EmployeeForm_Click(object sender, RoutedEventArgs e)
        {
            EmployeeManagerForm emf = new EmployeeManagerForm();
            emf.Show();
            this.Hide();
        }

        private void btn_Statistics_Click(object sender, RoutedEventArgs e)
        {
            MonthlyReportForm mrf = new MonthlyReportForm();
            mrf.Show();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_Update.IsEnabled = true;
            btn_Delete.IsEnabled = true;
            btn_Refresh.IsEnabled = true;
            btn_AddNew.IsEnabled = false;
            txt_Type.IsEnabled = false;
            DataGrid d = (DataGrid)sender;
            DataRowView row_selected = d.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txt_Type.Text = row_selected["type"].ToString();
                txt_Description.Text = row_selected["description"].ToString();
                txt_Price.Text = row_selected["price"].ToString();
                txt_Inventory.Text = row_selected["inventory"].ToString();
                product_id = (Int32)row_selected["product_id"];
            }
        }

        private void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            btn_Update.IsEnabled = false;
            btn_Delete.IsEnabled = false;
            btn_AddNew.IsEnabled = true;
            txt_Type.IsEnabled = true;
            RefreshTextFields();
        }

        private void btn_AddNew_Click(object sender, RoutedEventArgs e)
        {
            if(!CheckValidate.checkForType(txt_Type.Text.ToString())){
                MessageBox.Show("Type must be characters.", "Error!");
            }
            if(!CheckValidate.checkForPrice(txt_Price.Text.ToString()))
            {
                MessageBox.Show("Price must be numbers, can use Comma and Decimal.", "Error!");
            }
            if (!CheckValidate.checkForInventory(txt_Inventory.Text.ToString()))
            {
                MessageBox.Show("Inventory must be natural numbers.", "Error!");
            }
            if (CheckValidate.checkForType(txt_Type.Text.ToString()) && CheckValidate.checkForPrice(txt_Price.Text.ToString()) && CheckValidate.checkForInventory(txt_Inventory.Text.ToString()))
            {
                cmd = new SqlCommand("INSERT INTO tbl_product(type, description, price, inventory) values(@type, @description, @price, @inventory)", sqlCon);
                sqlCon.Open();
                cmd.Parameters.AddWithValue("@type", txt_Type.Text);
                cmd.Parameters.AddWithValue("@description", txt_Description.Text);
                cmd.Parameters.AddWithValue("@price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@inventory", txt_Inventory.Text);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Data Inserted Successfully !!!", "Message");
                LoadData();
                RefreshTextFields();
            }
        }

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckValidate.checkForType(txt_Type.Text.ToString()))
            {
                MessageBox.Show("Type must be characters with start by Uppercase.", "Error!");
            }
            if (!CheckValidate.checkForPrice(txt_Price.Text.ToString()))
            {
                MessageBox.Show("Price must be numbers, can use Comma and Decial.", "Error!");
            }
            if (!CheckValidate.checkForInventory(txt_Inventory.Text.ToString()))
            {
                MessageBox.Show("Inventory must be natural numbers.", "Error!");
            }
            if (CheckValidate.checkForType(txt_Type.Text.ToString()) && CheckValidate.checkForPrice(txt_Price.Text.ToString()) && CheckValidate.checkForInventory(txt_Inventory.Text.ToString()))
            {
                cmd = new SqlCommand("update tbl_product SET type = @type, description = @description, price = @price, inventory = @inventory WHERE product_id = @product_id ", sqlCon);
                sqlCon.Open();
                cmd.Parameters.AddWithValue("@type", txt_Type.Text);
                cmd.Parameters.AddWithValue("@description", txt_Description.Text);
                cmd.Parameters.AddWithValue("@price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@inventory", txt_Inventory.Text);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Data Updated Successfully !!!", "Message");
                LoadData();
                RefreshTextFields();
                btn_Update.IsEnabled = false;
                btn_Delete.IsEnabled = false;
                btn_Refresh.IsEnabled = false;
                btn_AddNew.IsEnabled = true;
                txt_Type.IsEnabled = true;
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            try {
                MessageBox.Show($"Are you sure?");
                cmd = new SqlCommand("DELETE from tbl_product WHERE product_id = @product_id", sqlCon);
                sqlCon.Open();
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
                sqlCon.Close();
                LoadData();
                RefreshTextFields(); 
                btn_Update.IsEnabled = false;
                btn_Delete.IsEnabled = false;
                btn_Refresh.IsEnabled = false;
                btn_AddNew.IsEnabled = true;
                txt_Type.IsEnabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
