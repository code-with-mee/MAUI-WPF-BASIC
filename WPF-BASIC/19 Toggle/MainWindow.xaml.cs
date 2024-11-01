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

namespace _19_Toggle
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

        private void tgl_Checked(object sender, RoutedEventArgs e)
        {
            tgl.Content = "On";
            MessageBox.Show("Checked");
        }

        private void tgl_Unchecked(object sender, RoutedEventArgs e)
        {
            tgl.Content = "Off";
            MessageBox.Show("Unchecked");
        }
    }
}