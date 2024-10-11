using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using CinemaApp.Data;
using CinemaApp.Data.Models;
using CinemaApp.Web.Infrastructure.Extensions;

namespace CinemaApp.Web
{
	public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("SQLServer")!;

            // Add services to the container.
            builder.Services
                .AddDbContext<CinemaDbContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                });

            builder.Services
                .AddDefaultIdentity<ApplicationUser>(cfg =>
                {

                })
                .AddRoles<IdentityRole<Guid>>()
                .AddSignInManager<SignInManager<ApplicationUser>>()
                .AddUserManager<UserManager<ApplicationUser>>()
				.AddEntityFrameworkStores<CinemaDbContext>();

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Authorization can only work if we know who uses the application
            app.UseAuthentication(); // First -> Who am I?
            app.UseAuthorization(); // Second -> What can I do?

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages(); // Add routing to Identity Razor Pages

            app.ApplyMigrations();

			app.Run();
        }
    }
}
