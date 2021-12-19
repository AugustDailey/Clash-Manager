using Newtonsoft.Json;

namespace ClashManager.Domain.Models
{
    public class War
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        [JsonProperty(PropertyName = "teamSize")]
        public int TeamSize { get; set; }

        [JsonProperty(PropertyName = "preparationStartTime")]
        public string PreparationStartTime { get; set; }

        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        [JsonProperty(PropertyName = "clan")]
        public Clan Clan { get; set; }

        [JsonProperty(PropertyName = "opponent")]
        public Clan Opponent { get; set; }
    }
}
