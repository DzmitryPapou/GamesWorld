using GamesWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesWorld.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
       

        

        public DbSet<Game> Games { get; set; }
        public EFDbContext(string connectionString) : base(nameOrConnectionString: connectionString)
        { }
    }
}
