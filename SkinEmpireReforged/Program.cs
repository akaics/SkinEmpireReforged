
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;
using SkinEmpireReforged.Areas.Identity.Data;

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

            //Configure Identity (MS learning)
           
            
            builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<TwinsDbContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();

           //builder.Services.AddScoped<UserManager<ApplicationUser>, UserManager<ApplicationUser>>();
          // builder.Services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();

            // !!!!!NY: ADMIN ROLE
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdministratorRole",
                     policy => policy.RequireRole("Admin"));
            });

          
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
