using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static GameZone.Constants.ModelConstants;

namespace GameZone.Data
{
	public class Genre
	{
		[Key]
		[Comment("Genre Unique Identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(GenreMaxNameLength)]
		[Comment("Genre name")]
		public string Name { get; set; } = null!;

		public IList<Game> Games { get; set; } = new List<Game>();
    }
}
