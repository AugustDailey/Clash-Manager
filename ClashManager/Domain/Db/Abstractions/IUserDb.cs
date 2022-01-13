using ClashManager.Domain.Db.Models;

namespace ClashManager.Domain.Db.Abstractions
{
    public interface IUserDb
    {
        UserDbResponse GetUser(string id);
        UserDbResponse CreateUser(User user);
        UserDbResponse DeleteUser(string id);
    }
}
