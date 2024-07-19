using System;
using System.Linq;
using System.Windows;
using ThangNPHE151263_FinalProject.Models;
using Services;
using Repositories;

namespace ThangNPHE151263_FinalProject
{
    /// <summary>
    /// Interaction logic for OrderPaymentWindow.xaml
    /// </summary>
    public partial class OrderPaymentWindow : Window
    {
        private Bill _currentBill;
        private BillService _billService;

        public OrderPaymentWindow(Bill currentBill)
        {
            InitializeComponent();
            _currentBill = currentBill;
            _billService = new BillService(new BillRepository(new MilkTeaContext())); 

            ListViewOrderDetails.ItemsSource = _currentBill.BillDetails;
            UpdateTotalAmount();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            Bill newBill = new Bill
            {
                BillDate = DateTime.Now,
                TotalMoney = _currentBill.BillDetails.Sum(detail => detail.IntoMoney ?? 0),
            };

            bool success = _billService.AddBill(newBill);

            if (success)
            {
                MessageBox.Show("Successfully! Thank You!", "Notify", MessageBoxButton.OK, MessageBoxImage.Information);

                _currentBill.BillDetails.Clear();
                Application.Current.Properties["CurBill"] = _currentBill;

                this.Close();
            }
            else
            {
                MessageBox.Show("Error. Please try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateTotalAmount()
        {
            double totalAmount = _currentBill.BillDetails.Sum(detail => detail.IntoMoney ?? 0);
            TotalAmountTextBlock.Text = $"Total Amount: {totalAmount.ToString()}" + " VND";
        }
    }
}
