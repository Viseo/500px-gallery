using FiveHundredPxGallery.Services.FiveHundredPx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace FiveHundredPxGallery.Models
{
    public class Thumbnail
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ImageSource Image { get; private set; }

        public Thumbnail(int id, string name, string description, BitmapImage image)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
        }
    }
}
