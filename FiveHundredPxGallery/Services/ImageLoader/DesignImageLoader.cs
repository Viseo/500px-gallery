using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace FiveHundredPxGallery.Services.ImageLoader
{
    public class DesignImageLoader : IImageLoader
    {
        private static Random _random = new Random(Guid.NewGuid().GetHashCode());

        public async Task<BitmapImage> GetFromUrl(string url)
        {
            var color = Color.FromArgb((byte)_random.Next(255), (byte)_random.Next(255), (byte)_random.Next(255), (byte)_random.Next(255));
            byte[] pxl = new byte[4 * 80 * 80];
            for (int i = 0; i < pxl.Length; i += 4)
            {
                pxl[i + 0] = color.B;
                pxl[i + 1] = color.G;
                pxl[i + 2] = color.R;
                pxl[i + 3] = color.A;
            }

            using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                var image = new BitmapImage();
                await stream.WriteAsync(pxl.AsBuffer());
                stream.Seek(0);
                image.SetSource(stream);
                return image;
            }
        }
    }
}
