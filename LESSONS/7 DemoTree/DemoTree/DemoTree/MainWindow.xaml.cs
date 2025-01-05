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

namespace DemoTree
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string content = txtInput.Text;
            TreeViewItem selectedItem = (TreeViewItem)treeView.SelectedItem;
            if (selectedItem != null)
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = txtInput.Text;
                selectedItem.Items.Add(item);
            }
            else
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = txtInput.Text;
                treeView.Items.Add(item);
            }
          
            txtInput.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem selectedItem = (TreeViewItem)treeView.SelectedItem;
            if (selectedItem != null)
            {
                //treeView.Items.RemoveAt(treeView.Items.IndexOf(treeView.SelectedItem));
                treeView.Items.Remove(selectedItem);
            }
        }
    }
}
