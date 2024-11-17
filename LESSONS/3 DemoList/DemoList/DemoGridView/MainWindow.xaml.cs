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

namespace DemoDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Person> persons = new List<Person>();
            persons.Add(new Person(1, "both", "kompongcham"));
            persons.Add(new Person(2, "channa", "phnom penh"));
            persons.Add(new Person(3, "pheakdey", "prey veng"));

            dgPerson.ItemsSource = persons;
            dgPerson2.ItemsSource = persons;
        }
    }
}
