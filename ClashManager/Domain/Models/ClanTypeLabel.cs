using Newtonsoft.Json;

namespace ClashManager.Domain.Models
{
    public class ClanTypeLabel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "iconUrls")]
        public IconUrls IconUrls { get; set; }
    }
}
