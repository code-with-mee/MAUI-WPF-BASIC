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

namespace DemoSystemTray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //insta package
        //https://www.nuget.org/packages/Hardcodet.NotifyIcon.Wpf/
        public MainWindow()
        {
            InitializeComponent();

            taskbarIcon.Visibility = System.Windows.Visibility.Visible;
        }

        private void menuShow_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnHide_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
