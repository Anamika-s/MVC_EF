using MVC_EF.Context;
using MVC_EF.Models;

namespace MVC_EF.Repository
{
    public class UserRepository1 : IUserRepository
    {
        List<User> _users = new List<User>()
        {
            new User(){UserId=1, Name="Aa"}
        };
         public UserRepository1() { }
        

        public List<User> GetUsers()
        {
            return  _users.ToList();
        }

        public User GetUserById(int id)
        {
            return null;
            //_db.Users.FirstOrDefault(x => x.UserId == id);
            //}
        }
        public User Create(User user)
        {
                return null;
            }
        public int Delete(int id)
        {
                 return 1;
        }
        public int Edit(int id, User user)
        {
                 return 0;
            
                return 1;
        }

    }
}
