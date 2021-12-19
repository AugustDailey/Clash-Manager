using Newtonsoft.Json;

namespace ClashManager.Domain.Models
{
    public class WarLeague
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
