using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using CinemaApp.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace CinemaApp.Data
{
	public class CinemaDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public CinemaDbContext()
        {
            
        }

        public CinemaDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<Movie> Movies { get; set; } = null!;

        public virtual DbSet<Cinema> Cinemas { get; set; } = null!;

        public virtual DbSet<CinemaMovie> CinemaMovies { get; set; } = null!;

        public virtual DbSet<ApplicationUserMovie> UsersMovies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
