namespace ClashManager.Domain.Services.Configuration
{
    public interface IConfigurationService
    {
        string GetApiToken();
        string GetClashApiBaseUrl();
        string GetAccountDbConnectionString();
    }
}