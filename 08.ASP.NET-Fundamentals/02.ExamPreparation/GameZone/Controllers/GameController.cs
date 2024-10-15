using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using GameZone.Models;
using GameZone.Data;

using static GameZone.Constants.ModelConstants;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Globalization;
using System.Security.Policy;

namespace GameZone.Controllers
{
	[Authorize]
	public class GameController : Controller
	{
		private readonly GameZoneDbContext context;

        public GameController(GameZoneDbContext _context)
        {
			context = _context;
        }

		[HttpGet]
        public async Task<IActionResult> All()
		{
			var model = await context.Games
				.Where(g => g.IsDeleted == false)
				.Select(g => new GameInfoViewModel()
				{
					Id = g.Id,
					Genre = g.Genre.Name,
					ImageUrl = g.ImageUrl,
					Publisher = g.Publisher.UserName ?? string.Empty,
					ReleasedOn = g.ReleasedOn.ToString(String.Format(GameReleasedOnDateFormat)),
					Title = g.Title
				})
				.AsNoTracking()
				.ToListAsync();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var model = new GameViewModel();
			model.Genres = await GetGenres();

            return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(GameViewModel model)
		{
			if (ModelState.IsValid == false)
			{
                model.Genres = await GetGenres();

                return View(model);
			}

			DateTime releasedOn;

			if (DateTime.TryParseExact(model.ReleasedOn, GameReleasedOnDateFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out releasedOn) == false)
			{
				ModelState.AddModelError(nameof(model.ReleasedOn), "Invalid date format");

                return View(model);
            }
			
			Game game = new Game()
			{
				Description = model.Description,
				GenreId = model.GenreId,
				ImageUrl = model.ImageUrl,
				PublisherId = GetCurrentUserId() ?? string.Empty,
				ReleasedOn = releasedOn,
				Title = model.Title
            };

			await context.Games.AddAsync(game);
			await context.SaveChangesAsync();

			return RedirectToAction(nameof(All));
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = await context.Games
				.Where(g => g.Id == id)
				.Where(g => g.IsDeleted == false)
				.AsNoTracking()
				.Select(g => new GameViewModel()
				{
					Description = g.Description,
					GenreId = g.GenreId,
					ImageUrl = g.ImageUrl,
					ReleasedOn = g.ReleasedOn.ToString(GameReleasedOnDateFormat),
					Title = g.Title
				})
				.FirstOrDefaultAsync();

			model.Genres = await GetGenres();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(GameViewModel model, int id)
		{
            if (ModelState.IsValid == false)
            {
                model.Genres = await GetGenres();

                return View(model);
            }

            DateTime releasedOn;

            if (DateTime.TryParseExact(model.ReleasedOn, GameReleasedOnDateFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out releasedOn) == false)
            {
                ModelState.AddModelError(nameof(model.ReleasedOn), "Invalid date format");

                return View(model);
            }

			Game? game = await context.Games.FindAsync(id);

			if (game == null || game.IsDeleted)
			{
				throw new ArgumentException("Invalid ID");
			}

			string currentUserId = GetCurrentUserId() ?? string.Empty;

			if (game.PublisherId != currentUserId)
			{
				return RedirectToAction(nameof(All));
			}

            game.Description = model.Description;
            game.GenreId = model.GenreId;
            game.ImageUrl = model.ImageUrl;
            game.ReleasedOn = releasedOn;
            game.Title = model.Title;

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

		[HttpGet]
		public async Task<IActionResult> MyZone()
		{
			string currentUserId = GetCurrentUserId() ?? string.Empty;

            var model = await context.Games
                .Where(g => g.IsDeleted == false)
				.Where(g => g.GamersGames.Any(gr => gr.GamerId == currentUserId))
                .Select(g => new GameInfoViewModel()
                {
                    Id = g.Id,
                    Genre = g.Genre.Name,
                    ImageUrl = g.ImageUrl,
                    Publisher = g.Publisher.UserName ?? string.Empty,
                    ReleasedOn = g.ReleasedOn.ToString(String.Format(GameReleasedOnDateFormat)),
                    Title = g.Title
                })
                .AsNoTracking()
                .ToListAsync();

            return View(model);
        }

		[HttpGet]
		public async Task<IActionResult> AddToMyZone(int id)
		{
            Game? game = await context.Games
				.Where(g => g.Id == id)
				.Include(g => g.GamersGames)
				.FirstOrDefaultAsync();

            if (game == null || game.IsDeleted)
            {
                throw new ArgumentException("Invalid ID");
            }

            string currentUserId = GetCurrentUserId() ?? string.Empty;

			if (game.GamersGames.Any(gr => gr.GamerId == currentUserId))
			{
                return RedirectToAction(nameof(All));
            }

            game.GamersGames.Add(new GamerGame()
            {
                GamerId = currentUserId,
                GameId = game.Id
            });

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(MyZone));
        }

		[HttpGet]
		public async Task<IActionResult> StrikeOut(int id)
		{
            Game? game = await context.Games
                .Where(g => g.Id == id)
                .Include(g => g.GamersGames)
                .FirstOrDefaultAsync();

            if (game == null || game.IsDeleted)
            {
                throw new ArgumentException("Invalid ID");
            }

            string currentUserId = GetCurrentUserId() ?? string.Empty;

			GamerGame? gamerGame = game.GamersGames
				.FirstOrDefault(gr => gr.GamerId == currentUserId);

            if (gamerGame != null)
            {
				game.GamersGames.Remove(gamerGame);

                await context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(MyZone));
        }

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
            var model = await context.Games
                .Where(g => g.Id == id)
                .Where(g => g.IsDeleted == false)
                .AsNoTracking()
                .Select(g => new GameDetailsViewModel()
                {
					Id = g.Id,
                    Description = g.Description,
                    Genre = g.Genre.Name,
                    ImageUrl = g.ImageUrl,
                    ReleasedOn = g.ReleasedOn.ToString(GameReleasedOnDateFormat),
                    Title = g.Title,
					Publisher = g.Publisher.UserName ?? string.Empty
                })
                .FirstOrDefaultAsync();

            return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
            var model = await context.Games
                .Where(g => g.Id == id)
                .Where(g => g.IsDeleted == false)
                .AsNoTracking()
                .Select(g => new DeleteViewModel()
                {
                    Id = g.Id,
                    Title = g.Title,
                    Publisher = g.Publisher.UserName ?? string.Empty
                })
                .FirstOrDefaultAsync();

            return View(model);
		}

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(DeleteViewModel model)
        {
			Game? game = await context.Games
				.Where(g => g.Id == model.Id)
				.Where(g => g.IsDeleted == false)
				.FirstOrDefaultAsync();

			if (game != null)
			{
				game.IsDeleted = true;

				await context.SaveChangesAsync();
			}

            return RedirectToAction(nameof(All));
        }

        private string? GetCurrentUserId()
		{
			return User.FindFirstValue(ClaimTypes.NameIdentifier);
		}

		private async Task<List<Genre>> GetGenres()
		{
			return await context.Genres.ToListAsync();
		}
	}
}
