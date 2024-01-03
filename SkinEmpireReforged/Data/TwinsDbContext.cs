using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SkinEmpireReforged
{
    public class TwinsDbContext : IdentityDbContext
    {
        public DbSet<Bruger> Brugere { get; set; }
        public DbSet<Skin> Skin { get; set; }
        public DbSet<SkinType> SkinTypes { get; set; }

        // Corrected the parameter type to DbContextOptions
        public TwinsDbContext(DbContextOptions<TwinsDbContext> options) : base(options)
        {
        }
    }
}
