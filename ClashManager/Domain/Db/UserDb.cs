using ClashManager.Domain.Db.Abstractions;
using ClashManager.Domain.Db.Models;
using ClashManager.Domain.Services.Configuration;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Data.SqlClient;

namespace ClashManager.Domain.Db
{
    public class UserDb : IUserDb
    {
        private ILogger<UserDb> Logger { get; }
        private MySqlConnection Connection { get; }
        public UserDb(IConfigurationService configurationService)
        {
            try
            {
                Connection = new MySqlConnection(configurationService.GetUserDbConnectionString());
            }
            catch (Exception e)
            {
                Logger.LogError($"An error occurred when attempting to create a connection to User Db. Exception: {e.Message}");
            }
        }

        public UserDbResponse CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public UserDbResponse DeleteUser(string id)
        {
            throw new System.NotImplementedException();
        }

        public UserDbResponse GetUser(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
