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

namespace _7_DatagridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Student> students = new List<Student>();
            students.Add(new Student(1,"ratana","0909090","phnom penh"));
            students.Add(new Student(2,"ratana","0909090","phnom penh"));
            students.Add(new Student(3,"ratana","0909090","phnom penh"));
            students.Add(new Student(4,"ratana","0909090","phnom penh"));
            students.Add(new Student(5,"ratana","0909090","phnom penh"));
            students.Add(new Student(6,"ratana","0909090","phnom penh"));

            dgv.ItemsSource = students;
        }
    }
}