using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveHundredPxGallery.Services.FiveHundredPx
{
    public class FiveHundredPxClient : IFiveHundredPxClient
    {
        private const string _baseUrl = "https://api.500px.com/v1/photos";
        private readonly string _consumerKey;

        public FiveHundredPxClient(string consumerKey)
        {
            _consumerKey = consumerKey;
        }
        public async Task<PhotoResponse> GetPopular(int page)
        {
            var url = _baseUrl
                .SetQueryParams(new { feature = "popular", page });

            AddConsumerKey(url);

            return await url.GetJsonAsync<PhotoResponse>();
        }

        public async Task<OnePhotoResponse> GetOne(int id)
        {
            var url = _baseUrl
                .AppendPathSegment(id.ToString())
                .SetQueryParams(new { image_size = 3 });

            AddConsumerKey(url);

            return await url.GetJsonAsync<OnePhotoResponse>();
        }

        private void AddConsumerKey(Url url)
        {
            if (_consumerKey != null)
                url = url.SetQueryParam("consumer_key", _consumerKey);
        }
    }
}
