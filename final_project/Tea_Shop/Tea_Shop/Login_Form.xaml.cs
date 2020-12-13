using DemoWPF;
using System;
using System.Collections.Generic;
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

namespace Tea_Shop
{
    /// <summary>
    /// Window1.xaml 
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private string userName = "Manager";
        private string userPassword = "Password";
        int chance = 3;

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Exit from System!");
            Close();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if(String.Compare(tex_UserName.Text, userName) == 0 && (String.Compare(txt_Password.Password, userPassword)) == 0 && chance > 0)
            {
                MessageBox.Show("Login Successfully!");
                //navigate to manager page
                EmployeeManagerForm emf = new EmployeeManagerForm();
                emf.Show();
                this.Hide();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong user name or password, please try again");
                chance -= 1;
            }
            if(chance < 0)
            {
                MessageBox.Show("You have reach the limitation of trying , Please try agin later");
            }
        }

        private void tex_UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
