using Microsoft.Win32;
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

using System.IO;

namespace DemoSharedDialog
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

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Text documents (.txt)|*.txt";
            var isOpen = openFileDialog.ShowDialog();
            if(isOpen == true)
            {
                string path = openFileDialog.FileName;
                txtBrowse.Text = path;

                string content = File.ReadAllText(path);
                tbDisplay.Text = content;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            var isOpen = saveFileDialog.ShowDialog();
            if (isOpen == true)
            {
                string path = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(tbDisplay.Text);
                writer.Close();
                MessageBox.Show("Save completed");
            }
        }
    }
}
