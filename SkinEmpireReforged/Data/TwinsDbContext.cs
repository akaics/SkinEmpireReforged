using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SkinEmpireReforged.Model;

namespace SkinEmpireReforged.Data
{
    public class TwinsDbContext : DbContext
    {
   
        // SkinEmpireReforged's TwinsDbContext
        public TwinsDbContext(DbContextOptions<TwinsDbContext> options) : base(options)
        {
        }

        public DbSet<Bruger> Brugere { get; set; }
        public DbSet<Skin> Skin { get; set; }
        public DbSet<SkinType> SkinTypes { get; set; }

    }
}
