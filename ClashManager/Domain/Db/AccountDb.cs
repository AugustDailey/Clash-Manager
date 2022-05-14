using ClashManager.Domain.Db.Abstractions;
using ClashManager.Domain.Db.Models;
using ClashManager.Domain.Services.Configuration;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Data;

namespace ClashManager.Domain.Db
{
    public class AccountDb : IAccountDb
    {
        private ILogger<AccountDb> Logger { get; }
        private MySqlConnection Connection { get; }
        public AccountDb(IConfigurationService configurationService)
        {
            try
            {
                Connection = new MySqlConnection(configurationService.GetAccountDbConnectionString());
                Connection.Open();
            }
            catch (Exception e)
            {
                Logger.LogError($"An error occurred when attempting to create a connection to User Db. Exception: {e.Message}");
            }
        }

        public AccountDbResponse CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public AccountDbResponse DeleteUser(string id)
        {
            throw new System.NotImplementedException();
        }

        public AccountDbResponse GetUser(string id)
        {
            throw new System.NotImplementedException();
        }

        public AccountDbResponse GetClans(string id)
        {
            var result = new AccountDbResponse();
            var query = $"Select ClanTag from Clans where ObjectId='{id}'";
            var command = new MySqlCommand(query);
            command.Connection = Connection;
            command.CommandType = CommandType.Text;
            using (var reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    result.Clans.Add(new Clan() { ClanTag = reader.GetString("ClanTag") });
                }
            }

            return result;
        }
    }
}
