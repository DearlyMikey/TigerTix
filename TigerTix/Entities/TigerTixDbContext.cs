using Microsoft.EntityFrameworkCore;

namespace TigerTix.Entities
{
    public class TigerTixDbContext : DbContext
    {
        public DbSet<UserAccount> UsersAccounts { get; set; }

        public TigerTixDbContext(DbContextOptions options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
