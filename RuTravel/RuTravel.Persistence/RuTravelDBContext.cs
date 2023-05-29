using Microsoft.EntityFrameworkCore;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class RuTravelDBContext : DbContext
    {
        public RuTravelDBContext(DbContextOptions<RuTravelDBContext> opt) : base(opt)
        {

        }
        public DbSet<Cafes> Cafes { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Flats> Flats { get; set; }
        public DbSet<Photos> Photos{ get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Sights> Sights { get; set; }
        public DbSet<Towns> Towns { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
