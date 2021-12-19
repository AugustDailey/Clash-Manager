using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashManager.Domain.Models
{
    public class Player
    {
        [JsonProperty(PropertyName = "clan")]
        public Clan Clan { get; set; }

        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "attackWins")]
        public int AttackWins { get; set; }

        [JsonProperty(PropertyName = "defenseWins")]
        public int DefenseWins { get; set; }

        [JsonProperty(PropertyName = "townHallLevel")]
        public int TownHallLevel { get; set; }

        [JsonProperty(PropertyName = "townHallWeaponLevel")]
        public int TownHallWeaponLevel { get; set; }

        [JsonProperty(PropertyName = "versusBattleWins")]
        public int VersusBattleWins { get; set; }

        [JsonProperty(PropertyName = "legendStatistics")]
        public LegendStatistics LegendStatistics { get; set; }

        [JsonProperty(PropertyName = "troops")]
        public List<Troop> Troops { get; set; }

        [JsonProperty(PropertyName = "heroes")]
        public List<Hero> Heroes { get; set; }

        [JsonProperty(PropertyName = "spells")]
        public List<Spell> Spells { get; set; }

        [JsonProperty(PropertyName = "labels")]
        public List<Label> Labels { get; set; }

        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "expLevel")]
        public int ExpLevel { get; set; }

        [JsonProperty(PropertyName = "trophies")]
        public int Trophies { get; set; }

        [JsonProperty(PropertyName = "bestTrophies")]
        public int BestTrophies { get; set; }

        [JsonProperty(PropertyName = "donations")]
        public int Donations { get; set; }

        [JsonProperty(PropertyName = "donationsReceived")]
        public int DonationsReceived { get; set; }

        [JsonProperty(PropertyName = "builderHallLevel")]
        public int BuilderHallLevel { get; set; }

        [JsonProperty(PropertyName = "versusTrophies")]
        public int VersusTrophies { get; set; }

        [JsonProperty(PropertyName = "bestVersusTrophies")]
        public int BestVersusTrophies { get; set; }

        [JsonProperty(PropertyName = "warStars")]
        public int WarStars { get; set; }

        [JsonProperty(PropertyName = "achievements")]
        public List<Achievement> Achievements { get; set; }

        [JsonProperty(PropertyName = "versusBattleWinCount")]
        public int VersusBattleWinCount { get; set; }
    }
}
