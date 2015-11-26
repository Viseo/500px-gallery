using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace FiveHundredPxGallery.Services.ImageLoader
{
    public interface IImageLoader
    {
        Task<BitmapImage> GetFromUrl(string url);
    }
}
