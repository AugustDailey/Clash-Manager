using ClashManager.Domain.Db.Models;

namespace ClashManager.Domain.Db.Abstractions
{
    public interface IAccountDb
    {
        AccountDbResponse GetUser(string id);
        AccountDbResponse CreateUser(User user);
        AccountDbResponse DeleteUser(string id);

        AccountDbResponse GetClans(string id);
    }
}
