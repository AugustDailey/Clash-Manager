using ClashManager.Domain.Services.Configuration;
using Microsoft.Extensions.Configuration;

namespace ClashTool.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationSection AppSettings;

        public ConfigurationService(IConfiguration configuration)
        {
            AppSettings = configuration.GetSection("AppSettings");
        }

        public string GetApiToken()
        {
            return AppSettings["ApiToken"];
        }

        public string GetClashApiBaseUrl()
        {
            return AppSettings["ClashApiBaseUrl"];
        }
    } 
}