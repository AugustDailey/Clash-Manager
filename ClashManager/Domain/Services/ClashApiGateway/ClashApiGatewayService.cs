using ClashManager.Domain.Models;
using ClashManager.Domain.Services.ClashHttp;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ClashManager.Domain.Services.ClashApiGateway
{
    public class ClashApiGateway : IClashApiGateway
    {
        private IClashHttpService ClashHttpService { get; set; }

        public ClashApiGateway(IClashHttpService clashHttpService)
        {
            ClashHttpService = clashHttpService;
        }

        public async Task<Clan> GetClanAsync(string clanTag)
        {
            var response = await ClashHttpService.Clans().ClanTag(clanTag).GetAsync();
            var clan = JsonConvert.DeserializeObject<Clan>(response);
            return clan;
        }

        public async Task<War> GetCurrentWarAsync(string clanTag)
        {
            var response = await ClashHttpService.Clans().ClanTag(clanTag).CurrentWar().GetAsync();
            var war = JsonConvert.DeserializeObject<War>(response);
            return war;
        }

        public async Task<WarLog> GetWarLogAsync(string clanTag)
        {
            var response = await ClashHttpService.Clans().ClanTag(clanTag).WarLog().GetAsync();
            var warLog = JsonConvert.DeserializeObject<WarLog>(response);
            return warLog;
        }

        public async Task<Player> GetPlayerAsync(string playerTag)
        {
            var response = await ClashHttpService.Players().PlayerTag(playerTag).GetAsync();
            var player = JsonConvert.DeserializeObject<Player>(response);
            return player;
        }

        public async Task<ClanWarLeague> GetClanWarLeagueGroup(string clanTag)
        {
            var response = await ClashHttpService.Clans().ClanTag(clanTag).CurrentWar().LeagueGroup().GetAsync();
            var warLeague = JsonConvert.DeserializeObject<ClanWarLeague>(response);
            return warLeague;
        }

        public async Task<War> GetClanWarLeagueWar(string warTag)
        {
            var response = await ClashHttpService.ClanWarLeagues().Wars().War(warTag).GetAsync();
            var war = JsonConvert.DeserializeObject<War>(response);
            return war;
        }
    }
}