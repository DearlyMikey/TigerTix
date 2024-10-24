using Microsoft.EntityFrameworkCore;
using TigerTix.Web.Data.Entities;

public class TigerTixContext : DbContext
{
    public DbSet<User> Users { get; set; }
}

