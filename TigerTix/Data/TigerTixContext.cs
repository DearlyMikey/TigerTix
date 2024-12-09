using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TigerTix.Entities;

namespace TigerTix.Data
{
    public class TigerTixContext : DbContext
    {
        public TigerTixContext (DbContextOptions<TigerTixContext> options)
            : base(options)
        {
        }

        public DbSet<TigerTix.Entities.Event> Event { get; set; } = default!;
    }
}
