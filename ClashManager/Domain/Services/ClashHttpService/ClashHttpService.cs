using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClashManager.Domain.Services.ClashHttpService
{
    public class ClashHttpService : IClashHttpService
    {
        private readonly string _apiToken;
        private readonly string _baseUrl;

        private string Path { get; set; }

        public ClashHttpService()
        {
        }

        public IClashHttpService Players()
        {
            Path += "/players";
            return this;
        }

        public IClashHttpService PlayerTag(string playerTag)
        {
            playerTag = playerTag.Replace("#", "%23");
            Path += $"/{playerTag}";
            return this;
        }

        public IClashHttpService Clans()
        {
            Path += "/clans";
            return this;
        }

        public IClashHttpService ClanTag(string clanTag)
        {
            clanTag = clanTag.Replace("#", "%23");
            Path += $"/{clanTag}";
            return this;
        }

        public IClashHttpService CurrentWar()
        {
            Path += $"/currentwar";
            return this;
        }

        public IClashHttpService LeagueGroup()
        {
            Path += $"/leaguegroup";
            return this;
        }

        public IClashHttpService WarLog()
        {
            Path += $"/warlog";
            return this;
        }

        public IClashHttpService ClanWarLeagues()
        {
            Path += $"/clanwarleagues";
            return this;
        }

        public IClashHttpService Wars()
        {
            Path += $"/wars";
            return this;
        }

        public IClashHttpService War(string warTag)
        {
            warTag = warTag.Replace("#", "%23");
            Path += $"/{warTag}";
            return this;
        }


        public async Task<string> GetAsync()
        {
            string result;

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiToken}");
                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                    var response = await client.GetAsync(_baseUrl + Path);
                    var content = await response.Content.ReadAsStringAsync();

                    // TODO: Figure out a cleaner way to do this
                    if (Path.Contains("currentwar") || Path.Contains("wars"))
                    {
                        content = content.Replace("members", "memberList");
                    }

                    result = content;
                }
            }
            catch (Exception e)
            {
                result = $"An error occurred. Error: {e.Message}";
            }

            Path = "";

            return result;
        }
    }
}
