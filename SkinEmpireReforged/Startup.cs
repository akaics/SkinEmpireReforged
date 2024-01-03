using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
namespace SkinEmpireReforged
{
    public class Startup
    {


        public void ConfigureServices(IServiceCollection services)
        {
            // Other service configurations...

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<TwinsDbContext>();

            // More service configurations...
        }
    }
}
