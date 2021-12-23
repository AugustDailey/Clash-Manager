using Newtonsoft.Json;

namespace ClashManager.Domain.Models
{
    public class IconUrls
    {
        [JsonProperty(PropertyName = "small")]
        public string Small { get; set; }

        [JsonProperty(PropertyName = "tiny")]
        public string Tiny { get; set; }

        [JsonProperty(PropertyName = "medium")]
        public string Medium { get; set; }
    }
}
