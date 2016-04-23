using System.Data.Entity;

namespace NasaSpaceAppsDbApi.Models
{
    public class NasaDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }

        public NasaDbContext() : base("name=NasaDbContext")
        {
        }
    }
}
