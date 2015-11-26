using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveHundredPxGallery.Services.FiveHundredPx
{
    public interface IFiveHundredPxClient
    {
        Task<PhotoResponse> GetPopular(int page);
        Task<OnePhotoResponse> GetOne(int id);
    }
}
