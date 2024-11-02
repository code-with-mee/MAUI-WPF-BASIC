using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _26_Mouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            txtInformation.Text = "mouse_enter";
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            txtInformation.Text = "mouse_leave";
        }

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            txtInformation.Text = "mouse_move";
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtInformation.Text = "mouse_down";
        }
    }
}