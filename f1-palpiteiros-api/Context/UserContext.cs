using Microsoft.EntityFrameworkCore;
using F1Palpiteiros.Model;

namespace F1Palpiteiros.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) {
            
        }

        public DbSet<User> Users { get; set; } = null;
    }
}
