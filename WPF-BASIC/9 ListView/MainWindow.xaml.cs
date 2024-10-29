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

namespace _9_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lv.Items.Add(new Student(1,"ratana","090909090","phnom penh"));
            lv.Items.Add(new Student(2,"ratana","090909090","phnom penh"));
            lv.Items.Add(new Student(3,"ratana","090909090","phnom penh"));
            lv.Items.Add(new Student(4,"ratana","090909090","phnom penh"));
        }
    }
}