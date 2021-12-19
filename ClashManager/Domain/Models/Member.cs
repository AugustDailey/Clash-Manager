using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClashManager.Domain.Models
{
    public class Member
    {
        // General Member Info
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "expLevel")]
        public int ExpLevel { get; set; }

        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        [JsonProperty(PropertyName = "trophies")]
        public int Trophies { get; set; }

        [JsonProperty(PropertyName = "versusTrophies")]
        public int VersusTrophies { get; set; }

        [JsonProperty(PropertyName = "clanRank")]
        public int ClanRank { get; set; }

        [JsonProperty(PropertyName = "previousClanRank")]
        public int PreviousClanRank { get; set; }

        [JsonProperty(PropertyName = "donations")]
        public int Donations { get; set; }

        [JsonProperty(PropertyName = "donationsReceived")]
        public int DonationsReceived { get; set; }

        // War Info
        [JsonProperty(PropertyName = "townhallLevel")]
        public int TownhallLevel { get; set; }

        [JsonProperty(PropertyName = "mapPosition")]
        public int MapPosition { get; set; }

        [JsonProperty(PropertyName = "opponentAttacks")]
        public int OpponentAttacks { get; set; }

        [JsonProperty(PropertyName = "BestOpponentAttack")]
        public Attack BestOpponentAttack { get; set; }

        [JsonProperty(PropertyName = "attacks")]
        public List<Attack> Attacks { get; set; }
    }
}
