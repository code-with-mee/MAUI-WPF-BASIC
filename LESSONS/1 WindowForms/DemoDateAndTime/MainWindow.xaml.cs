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
using System.Windows.Threading;

namespace DemoDateAndTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0,0,0);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tb1.Text = DateTime.Now.ToString();
            tb2.Text = DateTime.Now.ToString("hh:mm:ss");
            tb2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            tb3.Text = DateTime.Now.ToString("yyyy mm dd hh:mm:ss");
            tb4.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            tb5.Text = DateTime.Now.AddHours(5).ToString("ddd, dd MMM yyy HH:mm:ss GMT");

            //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
        }
    }
}
