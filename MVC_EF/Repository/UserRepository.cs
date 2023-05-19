using MVC_EF.Context;
using MVC_EF.Models;

namespace MVC_EF.Repository
{
    public class UserRepository : IUserRepository
    {
        UserDbContext _db;
        public UserRepository(UserDbContext db)
        {
            _db = db;
        }

        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _db.Users.FirstOrDefault(x => x.UserId == id);
        }

        public User Create(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return user;
        }
        public int Delete(int id)
        {
            User obj = GetUserById(id);
            if (obj != null)
            {
                _db.Users.Remove(obj);
                _db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }
        public int Edit(int id, User user)
        {
            User obj = GetUserById(id);
            if (obj != null)
            {
                foreach (User temp in _db.Users)
                {
                    if (temp.UserId == id)
                    {
                        temp.Address = user.Address;
                    }
                }
                _db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }

    }
}
