//Patrik Sullivan psullivan8@cnm.edu
//SullivanSprocketOrderForm
//6-30-20

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

namespace SullivanSprocketOrderForm
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        public SprocketForm()
        {
            InitializeComponent();
        }
        private Sprocket sprocket;
        public Sprocket Sprocket
        {
            get { return sprocket; }
            set { sprocket = value; }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = cbxItemType.SelectedIndex;
                int itemID = int.Parse(txtItemID.Text);
                int numTeeth = int.Parse(txtNumTeeth.Text);
                int numItems = int.Parse(txtNumItems.Text);
                switch (index)
                {
                    case 0:
                        sprocket = new AluminumSprocket(itemID, numItems, numTeeth);
                        break;
                    case 1:
                        sprocket = new PlasticSprocket(itemID, numItems, numTeeth);
                        break;
                    case 2:
                        sprocket = new SteelSprocket(itemID, numItems, numTeeth);
                        break;
                }
                DialogResult = true;
                Close();
            }
            catch (Exception)
            {
                DialogResult = false;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}