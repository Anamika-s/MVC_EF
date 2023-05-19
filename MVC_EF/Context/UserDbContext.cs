using Microsoft.EntityFrameworkCore;
using MVC_EF.Models;

namespace MVC_EF.Context
{
    public class UserDbContext :DbContext
    {
        public UserDbContext()
        {

        }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
