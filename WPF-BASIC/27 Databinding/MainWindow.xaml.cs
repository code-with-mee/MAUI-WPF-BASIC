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

namespace _27_Databinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 1; i <= 10; i++)
            {
                Student student = new Student(i,"student-"+i,"09090909"+ i,"address-"+ i);
                students.Add(student);
            }

            Clear();
        }

        private void Clear()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;

            int studentId = students.Count + 1;
            Student student = new Student(studentId,"","","");
            this.DataContext = student;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int studentId = int.Parse(txtId.Text);
            string studentName = txtName.Text;
            string studentPhone = txtPhone.Text;
            string studentAddress = txtAddress.Text;
            Student student = new Student(studentId,studentName,studentPhone,studentAddress);
            students.Add(student);

            Clear();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int studentId = int.Parse(txtId.Text);
            var student = students.FirstOrDefault(x => x.Id == studentId);
            if (student != null)
            {
                string studentName = txtName.Text;
                string studentPhone = txtPhone.Text;
                string studentAddress = txtAddress.Text;
                student.Name = studentName;
                student.Phone = studentPhone;
                student.Address = studentAddress;
            }
            MessageBox.Show("Update student complete!");
            Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int studentId = int.Parse(txtId.Text);
            var student = students.FirstOrDefault(x => x.Id == studentId);
            if (student != null) 
                students.Remove(student);
            MessageBox.Show("remove student : " + txtName.Text);
            Clear();

        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            StudentList studentList = new StudentList(students, this);
            studentList.Show();
        }

        public void BindData(Student student)
        {
            this.DataContext = student;
        }
    }
}