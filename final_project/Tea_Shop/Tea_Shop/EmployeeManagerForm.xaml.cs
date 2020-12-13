using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for EmployeeManagerForm.xaml
    /// </summary>
    public partial class EmployeeManagerForm : Window
    {
        public EmployeeManagerForm()
        {
            InitializeComponent();
            refreshdata();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sda;
        int ID = 0;

        private void btn_ProductForm_Click(object sender, RoutedEventArgs e)
        {
            ProductManagerForm pmf = new ProductManagerForm();
            pmf.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;
            if(row_selected != null)
            {
                txt_FirstName.Text = row_selected["first_name"].ToString();
                txt_LastName.Text = row_selected["last_name"].ToString();
                txt_Gender.Text = row_selected["gender"].ToString();
                txt_Email.Text = row_selected["email"].ToString();
                txt_Address.Text = row_selected["address"].ToString();
                txt_Country.Text = row_selected["country"].ToString();
                txt_State.Text = row_selected["state"].ToString();
                txt_City.Text = row_selected["city"].ToString();
                txt_PostalCode.Text = row_selected["postal_code"].ToString();
                txt_PhoneNumber.Text = row_selected["phone"].ToString();
                txt_DateOfBirth.Text = row_selected["birth"].ToString();
                ID = (Int32)row_selected["emp_id"];
            }
        }

        private void btn_AddNew_Click(object sender, RoutedEventArgs e)
        {
            if (ID <= 0)
            {
                if (txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_Gender.Text != "" && txt_Email.Text != "" && txt_Address.Text != "" && txt_Country.Text != ""
                    && txt_State.Text != "" && txt_City.Text != "" && txt_PostalCode.Text != "" && txt_PhoneNumber.Text != "" && txt_DateOfBirth.Text != "")
                {
                    cmd = new SqlCommand("insert into tbl_emp([first_name],[last_name],[gender],[email],[address],[country],[state],[city],[postal_code],[phone],[birth]) " +
                        "values(@fName,@lName,@gender,@email,@address,@country,@state,@city,@postal_code,@phone,@birth)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@fName", txt_FirstName.Text);
                    cmd.Parameters.AddWithValue("@lName", txt_LastName.Text);
                    cmd.Parameters.AddWithValue("@gender", txt_Gender.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                    cmd.Parameters.AddWithValue("@country", txt_Country.Text);
                    cmd.Parameters.AddWithValue("@state", txt_State.Text);
                    cmd.Parameters.AddWithValue("@city", txt_City.Text);
                    cmd.Parameters.AddWithValue("@postal_code", txt_PostalCode.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_PhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@birth", txt_DateOfBirth.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                    //refresh data
                    refreshdata();
                }
                else
                {
                    MessageBox.Show("Please fill all space");
                }
            }
            else
            {
                MessageBox.Show("The record already exist");
            }
        }

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            if(ID > 0)
            {
                if (txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_Gender.Text != "" && txt_Email.Text != "" && txt_Address.Text != "" && txt_Country.Text != ""
                    && txt_State.Text != "" && txt_City.Text != "" && txt_PostalCode.Text != "" && txt_PhoneNumber.Text != "" && txt_DateOfBirth.Text != "")
                {
                    cmd = new SqlCommand("update tbl_emp SET [first_name] = @fName,[last_name] = @lName,[gender] = @gender,[email] = @email,[address] = @address,[country] = @country,[state] = @state,[city] = @city,[postal_code] = @postal_code,[phone] = @phone,[birth] = @birth " +
                        "WHERE emp_id = @ID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@fName", txt_FirstName.Text);
                    cmd.Parameters.AddWithValue("@lName", txt_LastName.Text);
                    cmd.Parameters.AddWithValue("@gender", txt_Gender.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                    cmd.Parameters.AddWithValue("@country", txt_Country.Text);
                    cmd.Parameters.AddWithValue("@state", txt_State.Text);
                    cmd.Parameters.AddWithValue("@city", txt_City.Text);
                    cmd.Parameters.AddWithValue("@postal_code", txt_PostalCode.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_PhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@birth", txt_DateOfBirth.Text);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Update Successfully");
                    //refresh data
                    refreshdata();
                }
                else
                {
                    MessageBox.Show("Please fill all space");
                }
            }
            else
            {
                MessageBox.Show("Please select a record first");
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if(ID > 0)
            {
                MessageBox.Show($"Will Delete Record {txt_FirstName.Text} {txt_LastName.Text}");
                cmd = new SqlCommand("delete from tbl_emp WHERE emp_id = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                con.Close();
                refreshdata();
            }
        }

        private void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            refreshdata();
        }

        private void refreshdata()
        {
            cmd = new SqlCommand("SELECT * FROM tbl_emp", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ID = 0;
            //clear all field
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Gender.Text = "";
            txt_Email.Text = "";
            txt_Address.Text = "";
            txt_Country.Text = "";
            txt_State.Text = "";
            txt_City.Text = "";
            txt_PostalCode.Text = "";
            txt_PhoneNumber.Text = "";
            txt_DateOfBirth.Text = "";
            DataGrid_1.ItemsSource = dt.DefaultView;
        }
    }
}
