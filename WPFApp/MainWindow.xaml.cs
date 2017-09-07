using System;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnClear.Click += btnClear_Click;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var B = new BLL.Product();
            B.ErrorEvent += (s, ev) => MessageBox.Show(ev.Message);

            Entities.Product product =
                B.GetProductByID(Convert.ToInt16(tbSearchProductID.Text));

            if (product != null)
            {
                tbProductID.Text = product.ProductID.ToString();
                tbProductName.Text = product.ProductName;
                tbUnitPrice.Text = product.UnitPrice.ToString();
                tbUnitsInStock.Text = product.UnitsInStock.ToString();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbProductID.Text = "";
            tbProductName.Text = "";
            tbUnitPrice.Text = "";
            tbUnitsInStock.Text = "";
            tbSearchProductID.Text = "0";
        }
    }
}
