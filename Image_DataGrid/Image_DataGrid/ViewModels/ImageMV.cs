using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image_DataGrid.Models;
using System.Collections.ObjectModel;

namespace Image_DataGrid.ViewModels
{
    public class ImageMV
    {
        private ImageClass _ObjectImage;

        public ImageClass ObjIm
        {
            get { return _ObjectImage; }
            set { _ObjectImage = value; }
        }

    }
}
