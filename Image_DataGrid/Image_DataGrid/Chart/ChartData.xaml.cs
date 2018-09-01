using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Image_DataGrid.Chart
{
    /// <summary>
    /// Interaction logic for ChartData.xaml
    /// </summary>
    public partial class ChartData : UserControl
    {
        public ImageMV imageMV = new ImageMV();
        public ChartData()
        {
            InitializeComponent();
            DataContext = imageMV;
        }

        private void ImageItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start(imageMV.ObjIm.ImageUrl);
        }
    }
}
