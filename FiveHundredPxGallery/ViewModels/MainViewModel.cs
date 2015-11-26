using FiveHundredPxGallery.Models;
using FiveHundredPxGallery.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using Windows.UI.Xaml.Navigation;

namespace FiveHundredPxGallery.ViewModels
{
    public class MainViewModel : Mvvm.ViewModelBase
    {
        public string Message { get; private set; }

        private ThumbnailsCollection _thumbnails;
        public ThumbnailsCollection Thumbnails
        {
            get { return _thumbnails; }
            set { Set(ref _thumbnails, value); }
        }

        private RelayCommand<Thumbnail> _thumbnailClickCommand;

        public RelayCommand<Thumbnail> ThumbnailClickCommand
        {
            get
            {
                if (_thumbnailClickCommand == null)
                    _thumbnailClickCommand = new RelayCommand<Thumbnail>(t => NavigationService.Navigate(Pages.DetailPage, t));

                return _thumbnailClickCommand;
            }
        }

        public MainViewModel(ThumbnailsCollection thumbnailCollection)
        {
            _thumbnails = thumbnailCollection;
        }
        
        public override void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            base.OnNavigatedTo(parameter, mode, state);
        }
    }
}
