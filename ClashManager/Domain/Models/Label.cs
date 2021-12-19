using Newtonsoft.Json;

namespace ClashManager.Domain.Models
{
    public class Label
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "iconUrls")]
        public IconUrls IconUrls { get; set; }
    }
}
