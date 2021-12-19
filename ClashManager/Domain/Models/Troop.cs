using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class Troop
    {
        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "maxLevel")]
        public int MaxLevel { get; set; }

        [JsonProperty(PropertyName = "village")]
        public string Village { get; set; }

        public int UnitSpace { get; set; }
    }
}
