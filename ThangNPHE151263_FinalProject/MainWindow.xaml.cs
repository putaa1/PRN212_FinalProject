using ThangNPHE151263_FinalProject.Models;
using Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThangNPHE151263_FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductService _productService = new();
        private EmployeeService _employeeService = new();
        private TableService _tableService = new();
        private TableGroupService _tableGroupService = new();
        public List<Product> Products { get; set; }
        public Bill CurBill { get; set; } = null;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadMenu();
            LoadLoginUser();
            LoadTableGroups();
            LoadCurOrder();
        }

        public void LoadMenu()
        {
            ListViewProduct.ItemsSource = null;
            _productService = new ProductService();
            var products = _productService.GetAllProductList();
            DataContext = this;
            ListViewProduct.ItemsSource = products;
        }

        public void LoadLoginUser()
        {
            _employeeService = new EmployeeService();
            long loggedInEmpID = (long)Application.Current.Properties["LoggedInEmpID"];
            var loginEmp = _employeeService.GetLoginEmployee(loggedInEmpID);
            LoginEmpNameTextBox.Text = loginEmp.FullName;
        }
        public void LoadCurOrder()
        {
            ListViewOrder.ItemsSource = null;
            if (CurBill != null)
            {
                ListViewOrder.ItemsSource = CurBill.BillDetails;

            }
        }

        public void LoadTableGroups()
        {
           
        }

        public void Product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product selectedProduct = ListViewProduct.SelectedItem as Product;
            if (selectedProduct != null)
            {
                ProductChoosed productChoosed = new ProductChoosed(selectedProduct);
                productChoosed.ShowDialog();

                // Sau khi đóng ProductChoosed, cập nhật lại danh sách đơn hàng
                CurBill = (Bill)Application.Current.Properties["CurBill"];
                LoadCurOrder();
            }
        }




        //private void TabControlGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var selectedGroup = TabControlGroups.SelectedItem as TableGroupService;
        //    if (selectedGroup != null)
        //    {
        //        ListViewTable.ItemsSource = selectedGroup.GetTableGroupList();
        //    }
        //}

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void ItemHome_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurBill != null && CurBill.BillDetails.Count > 0)
            {
                OrderPaymentWindow orderPaymentWindow = new OrderPaymentWindow(CurBill);
                orderPaymentWindow.ShowDialog();
                LoadCurOrder();
            }
            else
            {
                MessageBox.Show("No products in the order to checkout.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewOrder.SelectedItem != null)
            {
                BillDetail selectedDetail = ListViewOrder.SelectedItem as BillDetail;
                CurBill.BillDetails.Remove(selectedDetail);
                LoadCurOrder();
            }
        }
    }
}
