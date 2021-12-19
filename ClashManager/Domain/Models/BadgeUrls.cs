using Newtonsoft.Json;

namespace ClashManager.Domain.Models
{
    public class BadgeUrls
    {
        [JsonProperty(PropertyName = "small")]
        public string Small { get; set; }

        [JsonProperty(PropertyName = "large")]
        public string Large { get; set; }

        [JsonProperty(PropertyName = "medium")]
        public string Medium { get; set; }
    }
}
