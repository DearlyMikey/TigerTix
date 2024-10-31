using Microsoft.EntityFrameworkCore;

namespace TigerTix.Entities
{
    public class TigerTixDbContext : DbContext
    {
        public TigerTixDbContext(DbContextOptions<TigerTixDbContext> options) : base(options) 
        {

        }

        public DbSet<UserAccount> UsersAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
