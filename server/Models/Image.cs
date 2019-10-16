using Newtonsoft.Json;


namespace server.Models
{
    public class Image
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int datetime { get; set; }
        public string type { get; set; }
        public bool animated { get; set; }
        public int width { get; set; }
        public int length { get; set; }
        public int size { get; set; }
        public int views { get; set; }
        public int bandwith { get; set; }
        public string deletehash { get; set; }
        public string name { get; set; }
        public string section { get; set; }
        public string link { get; set; }
        public string gifv { get; set; }
        public string mp4 { get; set; }
        [JsonProperty(PropertyName = "mp4_size")]
        public int mp4Size { get; set; }
        public bool looping { get; set; }
        public bool favorite { get; set; }
        public bool nsfw { get; set; }
        public string vote { get; set; }
        [JsonProperty(PropertyName = "in_gallery")]
        public bool inGallery { get; set; }
        [JsonProperty(PropertyName = "account_url")]
        public string accountUrl { get; set; }
        [JsonProperty(PropertyName = "account_id")]
        public int accountId { get; set; }
        [JsonProperty(PropertyName = "is_ad")]
        public bool isAd { get; set; }
        [JsonProperty(PropertyName = "in_most_viral")]
        public bool inMostViral { get; set; }
        [JsonProperty(PropertyName = "has_sound")]
        public bool hasSound { get; set; }
        public string[] tags { get; set; }
        [JsonProperty(PropertyName = "ad_type")]
        public int adType { get; set; }
        [JsonProperty(PropertyName = "ad_url")]
        public int adUrl { get; set; }
        public string edited { get; set; }
    }
}
