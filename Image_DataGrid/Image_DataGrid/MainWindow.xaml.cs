/*
@    Created By : MH.Movasaghinia
@    Contact : https://github.com/MMovasaghi
@    8.29.2018  
*/
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
using Image_DataGrid.ViewModels;
using Image_DataGrid.Chart;
using System.Net;

namespace Image_DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageMV imageMV = new ImageMV();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = imageMV;
        }
        int a = 0;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //xdata.ItemsSource = imageMV.Object;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var image = new Image();
            var fullFilePath = @"https://cdn.newsapi.com.au/image/v1/9fdbf585d17c95f7a31ccacdb6466af9";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image.Source = bitmap;

            ChartData chartData1 = new ChartData();
            chartData1.imageMV.ObjIm = new Models.ImageClass() { ImageUrl = fullFilePath, Price = 100 };
            chartData1.ImageItem.Children.Add(image);
            chartData1.PriceItem.Text = "100";
            xgrid.Children.Add(chartData1);
        }

        private void DowButton_Click(object sender, RoutedEventArgs e)
        {
            a++;
            using (WebClient client = new WebClient())
            {
                client.DownloadFileAsync(new Uri(@"https://cdn.newsapi.com.au/image/v1/9fdbf585d17c95f7a31ccacdb6466af9"), @"F:\Visual_Programs\Image_DataGrid\Image_DataGrid\"+ a + ".jpg");
            }
        }

        
    }
    
}
