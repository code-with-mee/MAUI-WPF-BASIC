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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _28_Custom_Control
{
    /// <summary>
    /// Interaction logic for MyTextBox.xaml
    /// </summary>
    public partial class MyTextBox : UserControl
    {
        private string placeHolder;
        public string PlaceHolder
        {
            get { return placeHolder; }
            set 
            { 
                placeHolder = value;
                tbPlaceHolder.Text = value;
            }
        }
        public MyTextBox()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = string.Empty;
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtInput.Text != string.Empty)
                tbPlaceHolder.Visibility= Visibility.Hidden;
            else
                tbPlaceHolder.Visibility= Visibility.Visible;
        }
    }
}
