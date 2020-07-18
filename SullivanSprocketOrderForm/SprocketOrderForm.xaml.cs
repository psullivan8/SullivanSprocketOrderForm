//Patrik Sullivan psullivan8@cnm.edu
//SullivanSprocketOrderForm
//6-30-20

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

//TODO: Nicely done  score 100/100

namespace SullivanSprocketOrderForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SprocketOrderForm : Window
    {
        private SprocketOrder order = new SprocketOrder();

        public SprocketOrderForm()
        {
            InitializeComponent();
            lbItems.ItemsSource = order.Items;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SprocketForm orderForm = new SprocketForm();
            orderForm.ShowDialog();
            //Test orderForm = new Test();
            //orderForm.ShowDialog();
            if (orderForm.DialogResult == true)
            {
                order.Add(orderForm.Sprocket);
                lbItems.Items.Refresh();
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbItems.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to remove this item?",
                                              "Confirm",
                                              MessageBoxButton.YesNo,
                                              MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    order.Remove((Sprocket)lbItems.SelectedItem);
                    lbItems.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("No item is selected!");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            order.CustomerName = txtCustomerName.Text;
            if (ckbxPickup.IsChecked == true)
            {
                order.Address = null;
            }
            else
            {
                order.Address = new Address();
                order.Address.Street = txtStreet.Text;
                order.Address.City = txtCity.Text;
                order.Address.State = txtState.Text;
                order.Address.ZipCode = txtZipCode.Text;
            }
            txtResults.Text = order.ToString();

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";
            if (saveFile.ShowDialog() == true)
            {
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile()))
                {
                    file.WriteLine(order.ToString());
                    foreach (var sprocket in order.Items)
                    {
                        file.WriteLine(sprocket.ToString());
                    }
                    file.Close();
                }
            }
        }

        private void ckbxPickup_Clicked(object sender, RoutedEventArgs e)
        {
            if (ckbxPickup.IsChecked == false)
            {
                txtStreet.Visibility = Visibility.Visible;
                txtCity.Visibility = Visibility.Visible;
                txtState.Visibility = Visibility.Visible;
                txtZipCode.Visibility = Visibility.Visible;
                lblStreet.Visibility = Visibility.Visible;
                lblCity.Visibility = Visibility.Visible;
                lblState.Visibility = Visibility.Visible;
                lblZipCode.Visibility = Visibility.Visible;
            }
            else
            {
                txtStreet.Visibility = Visibility.Hidden;
                txtCity.Visibility = Visibility.Hidden;
                txtState.Visibility = Visibility.Hidden;
                txtZipCode.Visibility = Visibility.Hidden;
                lblStreet.Visibility = Visibility.Hidden;
                lblCity.Visibility = Visibility.Hidden;
                lblState.Visibility = Visibility.Hidden;
                lblZipCode.Visibility = Visibility.Hidden;
            }
        }
    }
}
