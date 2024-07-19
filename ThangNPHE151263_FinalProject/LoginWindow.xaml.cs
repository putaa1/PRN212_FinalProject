using Services;
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

namespace ThangNPHE151263_FinalProject
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private LoginService _loginServices;

        public LoginWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            _loginServices = new LoginService();
            string loginUserName = UsernameTextBox.Text;
            string loginUserPassword = PasswordTextBox.Password;
            if (_loginServices.CheckLoginUser(loginUserName, loginUserPassword) == true)
            {
                Application.Current.Properties["LoggedInEmpID"] = _loginServices.GetEmployeeID(loginUserName, loginUserPassword);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or password", "Login Fail!!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Do you want to quit", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes) { Application.Current.Shutdown(); }

        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
