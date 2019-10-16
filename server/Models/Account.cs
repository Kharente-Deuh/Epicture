using Newtonsoft.Json;


namespace server.Models
{
    public class Account
    {
        public int id { get; set; }
        public string url { get; set; }
        public string bio { get; set; }
        public string avatar { get; set; }
        [JsonProperty(PropertyName = "avatar_name")]
        public string avatarName { get; set; }
        public string cover { get; set; }
        [JsonProperty(PropertyName = "cover_name")]
        public string coverName { get; set; }
        public int repitation { get; set; }
        [JsonProperty(PropertyName = "reputation_name")]
        public string reputationName { get; set; }
        [JsonProperty(PropertyName = "pro_expiration")]
        public bool proExpiration { get; set; }
        [JsonProperty(PropertyName = "user_follow")]
        public Basic userFollow { get; set; }
        [JsonProperty(PropertyName = "is_blocked")]
        public bool isBlocked { get; set; }
    }
}
