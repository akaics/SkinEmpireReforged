using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;
using SkinEmpireReforged.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using SkinEmpireReforged.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

/*Credits:
 * Kodet af Gülsüm og Nuriye Erdogan */
namespace SkinEmpireReforged
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddRazorPages();

            // Configure ApplicationDbContext
            builder.Services.AddDbContext<TwinsDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("TwinsConnection")
            ));

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<TwinsDbContext>();

            builder.Services.AddTransient<IEmailSender, EmailSender>();
            builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);
            builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration.GetSection("AuthMessageSenderOptions"));

            // API key  ((((user secrets!!)))
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            string apiKey = config["apikey"];

            Console.WriteLine(apiKey);

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();

            app.Run();
        }
    }
}
