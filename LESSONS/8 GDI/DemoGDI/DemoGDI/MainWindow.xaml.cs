using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace DemoGDI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Bitmap gdiBitmap = DrawWithGDI();
            img1.Source = ConvertToWpfImageSource(gdiBitmap);
            img2.Source = ConvertToWpfImageSource(gdiBitmap);
            img3.Source = ConvertToWpfImageSource(gdiBitmap);
        }

        private Bitmap DrawWithGDI()
        {
            Bitmap bitmap = new Bitmap(300, 300);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(Pens.Blue, 50, 50, 100, 100);
            g.DrawRectangle(Pens.Red, 50, 50, 100, 100);
            return bitmap;
        }

        private BitmapImage ConvertToWpfImageSource(Bitmap bitmap)
        {
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.EndInit();
            return image;
        }
    }
}
