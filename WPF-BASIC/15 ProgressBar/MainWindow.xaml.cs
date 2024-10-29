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

namespace _15_ProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SynchronizationContext context = SynchronizationContext.Current;
            Thread backgroundThread = new Thread(
            new ThreadStart(() =>
            {
                for (int n = 0; n < 100; n++)
                {
                    Thread.Sleep(50);
                    context?.Post(new SendOrPostCallback((o) =>
                    {
                        pg.Value = n;
                    }), null);
                };
            }
            ));
            backgroundThread.Start();

        }
    }
}