using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class ClanWarLeague
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        [JsonProperty(PropertyName = "clans")]
        public List<Clan> Clans { get; set; }

        [JsonProperty(PropertyName = "rounds")]
        public List<Round> Rounds { get; set; }
    }
}
