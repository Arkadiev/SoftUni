using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using CinemaApp.Data.Models;

using static CinemaApp.Common.EntityValidationConstants.Movie;
using static CinemaApp.Common.ApplicationConstants;

namespace CinemaApp.Data.Configuration
{
	public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder.Property(m => m.Genre)
                .IsRequired()
                .HasMaxLength(GenreMaxLength);

            builder.Property(m => m.Director)
                .IsRequired()
                .HasMaxLength(DirectorMaxLength);

            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLength);

            builder.Property(m => m.ImageUrl)
                .IsRequired(false)
                .HasMaxLength(ImageUrlMaxLength)
                .HasDefaultValue(NoImageUrl);


            builder.HasData(this.SeedMovies());
        }

        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie()
                {
                    Title = "Harry Potter and the Goblet of Fire",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2005, 11, 01),
                    Director = "Mike Newel",
                    Duration = 157,
                    Description = "Description not yet implemented"
                },
                new Movie()
                {
                    Title = "Lord of the Rings",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2001, 05, 01),
                    Director = "Peter Jackson",
                    Duration = 178,
                    Description = "Description not yet implemented"
                }
            };

            return movies;
        }
    }
}
