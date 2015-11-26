using Newtonsoft.Json;
using System.Collections.Generic;

namespace FiveHundredPxGallery.Services.FiveHundredPx
{
    public class PhotoResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }
        [JsonProperty("filters")]
        public Filters Filters { get; set; }
        [JsonProperty("feature")]
        public string Feature { get; set; }
    }

    public class Filters
    {
        [JsonProperty("category")]
        public bool Category { get; set; }
        [JsonProperty("exclude")]
        public bool Exclude { get; set; }
    }

    public class Photo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("camera")]
        public string Camera { get; set; }
        [JsonProperty("lens")]
        public object Lens { get; set; }
        [JsonProperty("focal_length")]
        public string FocalLength { get; set; }
        [JsonProperty("iso")]
        public string Iso { get; set; }
        [JsonProperty("shutter_speed")]
        public string ShutterSpeed { get; set; }
        [JsonProperty("aperture")]
        public string Aperture { get; set; }
        [JsonProperty("times_viewed")]
        public int TimesViewed { get; set; }
        [JsonProperty("rating")]
        public double Rating { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("category")]
        public int Category { get; set; }
        [JsonProperty("location")]
        public object Location { get; set; }
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
        [JsonProperty("taken_at")]
        public string TakenAt { get; set; }
        [JsonProperty("hi_res_uploaded")]
        public int HiResUploaded { get; set; }
        [JsonProperty("for_sale")]
        public bool ForSale { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("votes_count")]
        public int VotesCount { get; set; }
        [JsonProperty("favorites_count")]
        public int FavoritesCount { get; set; }
        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }
        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }
        [JsonProperty("sales_count")]
        public int SalesCount { get; set; }
        [JsonProperty("for_sale_date")]
        public object ForSaleDate { get; set; }
        [JsonProperty("highest_rating")]
        public double HighestRating { get; set; }
        [JsonProperty("highest_rating_date")]
        public string HighestRatingDate { get; set; }
        [JsonProperty("license_type")]
        public int LicenseType { get; set; }
        [JsonProperty("converted")]
        public bool Converted { get; set; }
        [JsonProperty("collections_count")]
        public int CollectionsCount { get; set; }
        [JsonProperty("crop_version")]
        public int CropVersion { get; set; }
        [JsonProperty("privacy")]
        public bool Privacy { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("images")]
        public List<Image> Images { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("positive_votes_count")]
        public int PositiveVotesCount { get; set; }
        [JsonProperty("converted_bits")]
        public int ConvertedBits { get; set; }
        [JsonProperty("store_download")]
        public bool StoreDownload { get; set; }
        [JsonProperty("store_print")]
        public bool StorePrint { get; set; }
        [JsonProperty("store_license")]
        public bool StoreLicense { get; set; }
        [JsonProperty("request_to_buy_enabled")]
        public bool RequestToBuyEnabled { get; set; }
        [JsonProperty("license_requests_enabled")]
        public bool LicenseRequestsEnabled { get; set; }
        [JsonProperty("watermark")]
        public bool Watermark { get; set; }
        [JsonProperty("image_format")]
        public string ImageFormat { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("licensing_requested")]
        public bool LicensingRequested { get; set; }
    }
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("usertype")]
        public int Usertype { get; set; }
        [JsonProperty("fullname")]
        public string Fullname { get; set; }
        [JsonProperty("userpic_url")]
        public string UserpicUrl { get; set; }
        [JsonProperty("userpic_https_url")]
        public string UserpicHttpsUrl { get; set; }
        [JsonProperty("cover_url")]
        public string CoverUrl { get; set; }
        [JsonProperty("upgrade_status")]
        public int UpgradeStatus { get; set; }
        [JsonProperty("store_on")]
        public bool StoreOn { get; set; }
        [JsonProperty("affection")]
        public int Affection { get; set; }
        [JsonProperty("avatars")]
        public Avatars Avatars { get; set; }
        [JsonProperty("admin")]
        public int? Admin { get; set; }
    }

    public class Avatars
    {
        [JsonProperty("default")]
        public Default Default { get; set; }
        [JsonProperty("large")]
        public Large Large { get; set; }
        [JsonProperty("small")]
        public Small Small { get; set; }
        [JsonProperty("tiny")]
        public Tiny Tiny { get; set; }
    }

    public class Default
    {
        [JsonProperty("https")]
        public string Https { get; set; }
    }

    public class Large
    {
        [JsonProperty("https")]
        public string Https { get; set; }
    }

    public class Small
    {
        [JsonProperty("https")]
        public string Https { get; set; }
    }

    public class Tiny
    {
        [JsonProperty("https")]
        public string Https { get; set; }
    }

    public class Image
    {
        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("https_url")]
        public string HttpsUrl { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
    }

    public class OnePhotoResponse
    {
        [JsonProperty("photo")]
        public Photo Photo { get; set; }
        [JsonProperty("comments")]
        public object[] Comments { get; set; }
    }

    public class Share_Counts
    {
    }

    public class Editored_By
    {
    }


}
