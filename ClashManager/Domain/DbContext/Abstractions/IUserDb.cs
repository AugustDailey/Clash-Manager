using ClashManager.Domain.DbContext.Models;

namespace ClashManager.Domain.DbContext.Abstractions
{
    public interface IUserDb
    {
        UserDbResponse GetUser(string id);
        UserDbResponse CreateUser(User user);
        UserDbResponse DeleteUser(string id);
    }
}
