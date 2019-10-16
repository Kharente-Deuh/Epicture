using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class AccountSettings
    {
        [JsonProperty(PropertyName = "account_url")]
        public string accountUrl { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
        public string cover { get; set; }
        [JsonProperty(PropertyName = "public_images")]
        public bool publicImages { get; set; }
        [JsonProperty(PropertyName = "album_privacy")]
        public string albumPrivacy { get; set; }
        [JsonProperty(PropertyName = "pro_expiration")]
        public bool proExpiration { get; set; }
        [JsonProperty(PropertyName = "accepted_gallery_terms")]
        public bool acceptedGalleryTerms { get; set; }
        [JsonProperty(PropertyName = "active_emails")]
        public string[] activeEmails { get; set; }
        [JsonProperty(PropertyName = "messaging_enabled")]
        public bool messagingEnabled { get; set; }
        [JsonProperty(PropertyName = "comment_replies")]
        public bool commentReplies { get; set; }
        [JsonProperty(PropertyName = "blocked_users")]
        public string[] blockedUsers { get; set; }
        [JsonProperty(PropertyName = "show_mature")]
        public bool showMature { get; set; }
        [JsonProperty(PropertyName = "newsletter_subscribed")]
        public bool newsletterSubscribed { get; set; }
        [JsonProperty(PropertyName = "first_party")]
        public bool firstParty { get; set; }
    }
}
