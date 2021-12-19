using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClashManager.Domain.Models
{
    public class Clan
    {
        // General Clan Info
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        [JsonProperty(PropertyName = "badgeUrls")]
        public BadgeUrls BadgeUrls { get; set; }

        [JsonProperty(PropertyName = "clanLevel")]
        public int ClanLevel { get; set; }

        [JsonProperty(PropertyName = "clanPoints")]
        public int ClanPoints { get; set; }

        [JsonProperty(PropertyName = "clanVersusPoints")]
        public int ClanVersusPoints { get; set; }

        [JsonProperty(PropertyName = "requiredTrophies")]
        public int RequiredTrophies { get; set; }

        [JsonProperty(PropertyName = "warFrequency")]
        public string WarFrequency { get; set; }

        [JsonProperty(PropertyName = "warWinStreak")]
        public int WarWinStreak { get; set; }

        [JsonProperty(PropertyName = "warWins")]
        public int WarWins { get; set; }

        [JsonProperty(PropertyName = "warTies")]
        public int WarTies { get; set; }

        [JsonProperty(PropertyName = "warLosses")]
        public int WarLosses { get; set; }

        [JsonProperty(PropertyName = "isWarLogPublic")]
        public bool IsWarLogPublic { get; set; }

        [JsonProperty(PropertyName = "warLeague")]
        public WarLeague WarLeague { get; set; }

        [JsonProperty(PropertyName = "members")]
        public int Members { get; set; }

        [JsonProperty(PropertyName = "memberList")]
        public List<Member> MemberList { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<ClanTypeLabel> Labels { get; set; }

        // War Info
        [JsonProperty(PropertyName = "attacks")]
        public int Attacks { get; set; }

        [JsonProperty(PropertyName = "stars")]
        public int Stars { get; set; }

        [JsonProperty(PropertyName = "expEarned")]
        public int ExpEarned { get; set; }

        [JsonProperty(PropertyName = "destructionPercentage")]
        public double DestructionPercentage { get; set; }
    }
}
