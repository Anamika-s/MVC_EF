using MVC_EF.Models;

namespace MVC_EF
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User Create(User user);
        User GetUserById(int id);
        int Delete(int id);
        int Edit(int id, User user);

    }
}
