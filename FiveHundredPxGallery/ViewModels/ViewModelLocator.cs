using FiveHundredPxGallery.Mvvm;
using FiveHundredPxGallery.Services.FiveHundredPx;
using FiveHundredPxGallery.Services.ImageLoader;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace FiveHundredPxGallery.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IFiveHundredPxClient, DesignFiveHundredPxClient>();
                SimpleIoc.Default.Register<IImageLoader, DesignImageLoader>();
                //SimpleIoc.Default.Register<IImageLoader, ImageLoader>();
            }
            else
            {
                SimpleIoc.Default.Register<IFiveHundredPxClient>(() => new FiveHundredPxClient("api_key"));
                SimpleIoc.Default.Register<IImageLoader, ImageLoader>();
            }
            SimpleIoc.Default.Register<ThumbnailsCollection>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<DetailViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public DetailViewModel Detail => ServiceLocator.Current.GetInstance<DetailViewModel>();
    }
}
