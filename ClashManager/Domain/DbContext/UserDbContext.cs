using ClashManager.Domain.DbContext.Abstractions;
using ClashManager.Domain.DbContext.Models;

namespace ClashManager.Domain.DbContext
{
    public class UserDb : IUserDb
    {
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
