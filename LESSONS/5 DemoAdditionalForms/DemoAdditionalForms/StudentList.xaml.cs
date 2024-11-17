using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace _27_Databinding
{
    /// <summary>
    /// Interaction logic for StudentList.xaml
    /// </summary>
    public partial class StudentList : Window
    {
        private List<Student> students;
        private MainWindow mainWindow;
        public StudentList(List<Student> students, MainWindow mainWindow)
        {
            InitializeComponent();

            this.students = students;
            this.mainWindow = mainWindow;

            dgv.ItemsSource = students;

        }

        private void dgv_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgv.SelectedItems.Count > 0)
            {
                int index = dgv.SelectedIndex;
                Student student = students[index];
                mainWindow.BindData(student);

                dgv.CommitEdit(DataGridEditingUnit.Row, true);

                this.Close();
            }
        }
    }
}
