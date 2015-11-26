using FiveHundredPxGallery.Models;
using FiveHundredPxGallery.Services.FiveHundredPx;
using FiveHundredPxGallery.Services.ImageLoader;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace FiveHundredPxGallery.ViewModels
{
    public class ThumbnailsCollection : ObservableCollection<Thumbnail>, ISupportIncrementalLoading
    {
        private readonly IFiveHundredPxClient _client;
        private readonly IImageLoader _imageLoader;
        private int _currentPage;

        public ThumbnailsCollection(IFiveHundredPxClient client, IImageLoader imageLoader)
        {
            _client = client;
            _imageLoader = imageLoader;
            _currentPage = 0;
            HasMoreItems = true;
        }

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            var dispatcher = Window.Current.Dispatcher;

            return Task.Run<LoadMoreItemsResult>(
                async () =>
                {
                    uint resultCount = 0;
                    _currentPage++;
                    var resp = await _client.GetPopular(_currentPage);

                    if (resp != null)
                    {
                        resultCount = (uint)resp.Photos.Count;

                        if (_currentPage >= resp.TotalPages)
                            HasMoreItems = false;
                        else
                        {
                            foreach (var photo in resp.Photos)
                            {
                                await dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                                async () =>
                                {
                                    var img = await _imageLoader.GetFromUrl(photo.ImageUrl);
                                    this.Add(new Thumbnail(photo.Id, photo.Name, photo.Description, img));
                                });
                            }
                        }
                    }

                    return new LoadMoreItemsResult() { Count = resultCount };

                }).AsAsyncOperation<LoadMoreItemsResult>();
        }

        public bool HasMoreItems { get; private set; }
    }
}
