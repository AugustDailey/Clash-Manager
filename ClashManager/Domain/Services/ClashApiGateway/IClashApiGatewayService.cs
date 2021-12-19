using ClashManager.Domain.Models;
using System.Threading.Tasks;

namespace ClashManager.Domain.Services.ClashApiGateway
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