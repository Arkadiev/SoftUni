using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static GameZone.Constants.ModelConstants;

namespace GameZone.Data
{
	public class Game
	{
        [Key]
        [Comment("Game Unique Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(GameMaxTitleLength)]
        [Comment("Game title")]
        public string Title { get; set; } = null!;

        [Required]
		[MaxLength(GameMaxDescriptionLength)]
        [Comment("Game description")]
		public string Description { get; set; } = null!;

        [Comment("The URL of the image")]
        public string? ImageUrl { get; set; }

        [Required]
        [Comment("Identifier of the game publisher")]
        public string PublisherId { get; set; } = null!;

        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        [Required]
        [Comment("Release date")]
        public DateTime ReleasedOn { get; set; }

        [Required]
        [Comment("Identifier of the game genre")]
        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        public IList<GamerGame> GamersGames { get; set; } = new List<GamerGame>();

        [Comment("Shows whether the game is deleted")]
        public bool IsDeleted { get; set; }
    }
}
