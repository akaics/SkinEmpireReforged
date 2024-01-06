using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

/*Credits:
 * Kodet af Gülsüm og Nuriye Erdogan */

namespace SkinEmpireReforged.Data
{
    public class TwinsDbContext : IdentityDbContext<ApplicationUser>
    {
        public TwinsDbContext(DbContextOptions<TwinsDbContext> options) : base(options)
        {
        }


        public DbSet<Skin> Skin { get; set; }
        public DbSet<SkinType> SkinTypes { get; set; }

        // Corrected the parameter type to DbContextOptions
     
    }
}
