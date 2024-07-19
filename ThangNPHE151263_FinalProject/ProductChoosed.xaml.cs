using ThangNPHE151263_FinalProject.Models;
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
    /// Interaction logic for ProductChoosed.xaml
    /// </summary>
    public partial class ProductChoosed : Window
    {
        public Product _product;

        public ProductChoosed(Product product)
        {
            InitializeComponent();
            _product = product;
            LoadLabel();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        public void LoadLabel()
        {
            ProductNameLabel.Content = _product.Name;
            ProductPriceLabel.Content = _product.UnitPrice * int.Parse(QuantityTextBox.Text);
        }
        private void DecresingButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(QuantityTextBox.Text) > 1)
            {
                QuantityTextBox.Text = (int.Parse(QuantityTextBox.Text) - 1).ToString();
                LoadLabel();
            }
            else
            {
                QuantityTextBox.Text = "1";
            }

        }

        private void IncresingButton_Click(object sender, RoutedEventArgs e)
        {
            QuantityTextBox.Text = (int.Parse(QuantityTextBox.Text) + 1).ToString();
            LoadLabel() ;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            _product.Unit = QuantityTextBox.Text;
            _product.Description = DescriptionTextBox.Text;
            BillDetail billDetail = new BillDetail() { Description = _product.Description, IdProduct = _product.Id, Quantity = int.Parse(_product.Unit), UnitPrice = _product.UnitPrice, IntoMoney = _product.UnitPrice * int.Parse(_product.Unit), IdProductNavigation = _product };
            if (Application.Current.Properties["CurBill"] == null)
            {
                Bill curBill = new Bill();
                curBill.BillDetails.Add(billDetail);
                Application.Current.Properties["CurBill"] = curBill;
            }
            else
            {
                Bill curBill = (Bill)Application.Current.Properties["CurBill"];

                foreach (var item in curBill.BillDetails)
                {
                    if (item.IdProduct == _product.Id)
                    {
                        item.Quantity += int.Parse(_product.Unit);
                        item.IntoMoney = item.Quantity * item.UnitPrice;
                        this.Close();
                        return;
                    }
                }

                curBill.BillDetails.Add(billDetail);
                Application.Current.Properties["CurBill"] = curBill;
            }
            this.Close();
        }
    }
}
