using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class LegendStatistics
    {
        [JsonProperty(PropertyName = "previousSeason")]
        public Season PreviousSeason { get; set; }

        [JsonProperty(PropertyName = "bestSeason")]
        public Season BestSeason { get; set; }

        [JsonProperty(PropertyName = "bestVersusSeason")]
        public Season BestVersusSeason { get; set; }

        [JsonProperty(PropertyName = "currentSeason")]
        public Season CurrentSeason { get; set; }

        [JsonProperty(PropertyName = "previousVersusSeason")]
        public Season PreviousVersusSeason { get; set; }

        [JsonProperty(PropertyName = "legendTrophies")]
        public int LegendTrophies { get; set; }
    }
}
