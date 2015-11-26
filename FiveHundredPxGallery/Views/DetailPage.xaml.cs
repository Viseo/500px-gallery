using FiveHundredPxGallery.ViewModels;
using Windows.UI.Xaml.Controls;

namespace FiveHundredPxGallery.Views
{
    public sealed partial class DetailPage : Page
    {
        public DetailPage()
        {
            this.InitializeComponent();
        }

        public DetailViewModel ViewModel => this.DataContext as DetailViewModel;
    }
}
