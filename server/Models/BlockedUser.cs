using Newtonsoft.Json;

namespace server.Models
{
    public class BlockedUser
    {
        [JsonProperty(PropertyName = "blocked_id")]
        public int blockedId { get; set; }
        [JsonProperty(PropertyName = "blocked_url")]
        public string blockedUrl { get; set; }
    }
}
