﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4_Checkbox
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = ((CheckBox)sender).Content + " is checked";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = ((CheckBox)sender).Content + " is unchecked";
        }
    }
}