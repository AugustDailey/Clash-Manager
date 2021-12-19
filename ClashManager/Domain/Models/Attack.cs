using Newtonsoft.Json;

namespace ClashManager.Domain.Models
{
    public class Attack
    {
        [JsonProperty(PropertyName = "attackerTag")]
        public string AttackerTag { get; set; }

        [JsonProperty(PropertyName = "defenderTag")]
        public string DefenderTag { get; set; }

        [JsonProperty(PropertyName = "stars")]
        public int Stars { get; set; }

        [JsonProperty(PropertyName = "destructionPercentage")]
        public int DestructionPercentage { get; set; }

        [JsonProperty(PropertyName = "order")]
        public int Order { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }
    }
}
