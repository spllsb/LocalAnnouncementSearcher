using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace src.Domain.Json
{
    public partial class Welcome
    {
        [JsonProperty("ad")]
        public WelcomeAd Ad { get; set; }

        [JsonProperty("categories")]
        public Categories Categories { get; set; }

        [JsonProperty("cookies")]
        public Cookies Cookies { get; set; }
    }

    public partial class WelcomeAd
    {
        [JsonProperty("ad")]
        public AdAd Ad { get; set; }

        [JsonProperty("currencies")]
        public Currencies Currencies { get; set; }

        [JsonProperty("fragments")]
        public Cookies Fragments { get; set; }

        [JsonProperty("seo")]
        public Seo Seo { get; set; }

        [JsonProperty("breadcrumbs")]
        public Breadcrumb[] Breadcrumbs { get; set; }

        [JsonProperty("maxAge")]
        public long MaxAge { get; set; }
    }

    public partial class AdAd
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("map")]
        public Map Map { get; set; }

        [JsonProperty("isBusiness")]
        public bool IsBusiness { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isHighlighted")]
        public bool IsHighlighted { get; set; }

        [JsonProperty("isPromoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty("promotion")]
        public Promotion Promotion { get; set; }

        [JsonProperty("delivery")]
        public Delivery Delivery { get; set; }

        [JsonProperty("lastRefreshTime")]
        public DateTimeOffset LastRefreshTime { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("params")]
        public Param[] Params { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("salary")]
        public object Salary { get; set; }

        [JsonProperty("partner")]
        public Partner Partner { get; set; }

        [JsonProperty("isJob")]
        public bool IsJob { get; set; }

        [JsonProperty("photos")]
        public string[] Photos { get; set; }

        [JsonProperty("photosSet")]
        public string[] PhotosSet { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("urlPath")]
        public string UrlPath { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("shop")]
        public Shop Shop { get; set; }

        [JsonProperty("safedeal")]
        public Safedeal Safedeal { get; set; }
    }


    public partial class Contact
    {
        [JsonProperty("chat")]
        public bool Chat { get; set; }

        [JsonProperty("courier")]
        public bool Courier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("negotiation")]
        public bool Negotiation { get; set; }

        [JsonProperty("phone")]
        public bool Phone { get; set; }
    }

    public partial class Delivery
    {
        [JsonProperty("rock")]
        public Rock Rock { get; set; }
    }

    public partial class Rock
    {
        [JsonProperty("offer_id")]
        public object OfferId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("cityId")]
        public long CityId { get; set; }

        [JsonProperty("cityNormalizedName")]
        public string CityNormalizedName { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionId")]
        public long RegionId { get; set; }

        [JsonProperty("regionNormalizedName")]
        public string RegionNormalizedName { get; set; }

        [JsonProperty("districtName")]
        public object DistrictName { get; set; }

        [JsonProperty("districtId")]
        public long DistrictId { get; set; }

        [JsonProperty("pathName")]
        public string PathName { get; set; }
    }

    public partial class Map
    {
        [JsonProperty("zoom")]
        public long Zoom { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("radius")]
        public long Radius { get; set; }

        [JsonProperty("show_detailed")]
        public bool ShowDetailed { get; set; }
    }

    public partial class Param
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("normalizedValue")]
        public string NormalizedValue { get; set; }
    }

    public partial class Partner
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("budget")]
        public bool Budget { get; set; }

        [JsonProperty("free")]
        public bool Free { get; set; }

        [JsonProperty("exchange")]
        public bool Exchange { get; set; }

        [JsonProperty("regularPrice")]
        public RegularPrice RegularPrice { get; set; }
    }

    public partial class RegularPrice
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("negotiable")]
        public bool Negotiable { get; set; }

        [JsonProperty("priceFormatConfig")]
        public PriceFormatConfig PriceFormatConfig { get; set; }
    }

    public partial class PriceFormatConfig
    {
        [JsonProperty("decimalSeparator")]
        public string DecimalSeparator { get; set; }

        [JsonProperty("thousandsSeparator")]
        public string ThousandsSeparator { get; set; }
    }

    public partial class Promotion
    {
        [JsonProperty("highlighted")]
        public bool Highlighted { get; set; }

        [JsonProperty("urgent")]
        public bool Urgent { get; set; }

        [JsonProperty("top_ad")]
        public bool TopAd { get; set; }

        [JsonProperty("options")]
        public object[] Options { get; set; }

        [JsonProperty("b2c_ad_page")]
        public bool B2CAdPage { get; set; }

        [JsonProperty("premium_ad_page")]
        public bool PremiumAdPage { get; set; }
    }

    public partial class Safedeal
    {
        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("weight_grams")]
        public long WeightGrams { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("safedeal_blocked")]
        public bool SafedealBlocked { get; set; }
    }

    public partial class Shop
    {
        [JsonProperty("subdomain")]
        public object Subdomain { get; set; }
    }

    public partial class User
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("logo")]
        public object Logo { get; set; }

        [JsonProperty("otherAdsEnabled")]
        public bool OtherAdsEnabled { get; set; }

        [JsonProperty("socialNetworkAccountType")]
        public string SocialNetworkAccountType { get; set; }

        [JsonProperty("isOnline")]
        public bool IsOnline { get; set; }

        [JsonProperty("lastSeen")]
        public DateTimeOffset LastSeen { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("bannerDesktopURL")]
        public string BannerDesktopUrl { get; set; }

        [JsonProperty("logo_ad_page")]
        public object LogoAdPage { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("sellerType")]
        public string SellerType { get; set; }
    }

    public partial class Breadcrumb
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("categoryId", NullValueHandling = NullValueHandling.Ignore)]
        public long? CategoryId { get; set; }
    }

    public partial class Currencies
    {
        [JsonProperty("PLN")]
        public Pln Pln { get; set; }
    }

    public partial class Pln
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public partial class Cookies
    {
    }

    public partial class Seo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class Categories
    {
        [JsonProperty("list")]
        public Dictionary<string, List> List { get; set; }

        [JsonProperty("counts")]
        public long?[] Counts { get; set; }

        [JsonProperty("promos")]
        public Promo[] Promos { get; set; }
    }

    public partial class List
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("displayOrder")]
        public long DisplayOrder { get; set; }

        [JsonProperty("children")]
        public long[] Children { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

  

        [JsonProperty("isAdding")]
        public bool IsAdding { get; set; }

        [JsonProperty("isSearch")]
        public bool IsSearch { get; set; }

        [JsonProperty("isOfferSeek")]
        public bool IsOfferSeek { get; set; }

        [JsonProperty("privateBusiness")]
        public bool PrivateBusiness { get; set; }

        [JsonProperty("photosMax")]
        public long PhotosMax { get; set; }

        [JsonProperty("img", NullValueHandling = NullValueHandling.Ignore)]
        public string Img { get; set; }
    }

    public partial class Promo
    {
        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }
    }

    public partial class Icon
    {
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("big_image_url")]
        public string BigImageUrl { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }
    }


}