using FiveHundredPxGallery.ViewModels;
using Windows.UI.Xaml.Controls;

namespace FiveHundredPxGallery.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public MainViewModel ViewModel => this.DataContext as MainViewModel;

    }
}
