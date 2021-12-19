using ClashManager.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashTool.Services.Abstractions
{
    public interface IClashApiGateway
    {
        // Player
        Task<Player> GetPlayerAsync(string playerTag);

        // Clan
        Task<Clan> GetClanAsync(string clanTag);
        Task<War> GetCurrentWarAsync(string clanTag);
        Task<WarLog> GetWarLogAsync(string clanTag);
        Task<ClanWarLeague> GetClanWarLeagueGroup(string clanTag);
        Task<War> GetClanWarLeagueWar(string warTag);
    }
}