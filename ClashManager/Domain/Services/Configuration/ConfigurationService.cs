using ClashManager.Domain.Services.Configuration;
using Microsoft.Extensions.Configuration;

namespace ClashManager.Domain.Services.Configuration
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

        public string GetUserDbConnectionString()
        {
            return AppSettings["UserDbConnectionString"];
        }
    } 
}