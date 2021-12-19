using System.Threading.Tasks;

namespace ClashManager.Domain.Services.ClashHttpService
{
    public interface IClashHttpService
    {
        IClashHttpService Players();
        IClashHttpService PlayerTag(string playerTag);

        IClashHttpService Clans();
        IClashHttpService ClanTag(string clanTag);
        IClashHttpService CurrentWar();
        IClashHttpService LeagueGroup();
        IClashHttpService WarLog();
        IClashHttpService ClanWarLeagues();
        IClashHttpService Wars();
        IClashHttpService War(string warTag);

        Task<string> GetAsync();
    }
}
