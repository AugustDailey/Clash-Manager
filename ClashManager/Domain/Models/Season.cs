using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class Season
    {
        [JsonProperty(PropertyName = "trophies")]
        public int trophies { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public int Rank { get; set; }
    }
}
