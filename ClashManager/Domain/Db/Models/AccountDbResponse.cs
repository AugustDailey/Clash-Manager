using System.Collections.Generic;

namespace ClashManager.Domain.Db.Models
{
    public class AccountDbResponse
    {
        public bool Success { get; set; }
        public List<User> Users { get; set; }

        public List<Clan> Clans { get; set; }

        public AccountDbResponse()
        {
            Users = new List<User>();
            Clans = new List<Clan>();
        }

        public bool HasClans()
        {
            return Clans.Count > 0;
        }

        public bool HasUsers()
        {
            return Users.Count > 0;
        }
    }
}