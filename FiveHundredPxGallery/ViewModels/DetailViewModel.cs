using FiveHundredPxGallery.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace FiveHundredPxGallery.ViewModels
{
    public class DetailViewModel : Mvvm.ViewModelBase
    {
        private ImageSource _image;
        public ImageSource Image
        {
            get { return _image; }
            set { Set(ref _image, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { Set(ref _description, value); }
        }

        public override void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            LoadDetail((Thumbnail)parameter);
        }

        private void LoadDetail(Thumbnail t)
        {
            Name = t.Name;
            Description = t.Description;
            Image = t.Image;
        }

    }
}
