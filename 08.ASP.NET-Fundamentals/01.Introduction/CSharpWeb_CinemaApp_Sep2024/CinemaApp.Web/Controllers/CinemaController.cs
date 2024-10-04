using CinemaApp.Data;
using CinemaApp.Data.Models;
using CinemaApp.Web.ViewModels.Cinema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Web.Controllers
{
    public class CinemaController : Controller
    {
        private readonly CinemaDbContext dbContext;

        public CinemaController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
			IEnumerable<CinemaIndexViewModel> cinemas = await this.dbContext
                .Cinemas
                .Select(c => new CinemaIndexViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    Location = c.Location
                })
                .OrderBy(c => c.Location)
                .ToArrayAsync();

            return this.View(cinemas);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCinemaFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            Cinema cinema = new Cinema()
            {
                Name = model.Name,
                Location = model.Location
            };

            await this.dbContext.Cinemas.AddAsync(cinema);
            await this.dbContext.SaveChangesAsync();

            return this.RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(string? id)
        {
			Guid cinemaGuid = Guid.Empty;

			bool isIdValid = IsCinemaIdValid(id, ref cinemaGuid);
            if (!isIdValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

			Cinema? cinema = await this.dbContext
				.Cinemas
				.FirstOrDefaultAsync(c => c.Id == cinemaGuid);

			// Invalid (non-existing) GUID in the URL
			if (cinema == null)
			{
				return this.RedirectToAction(nameof(Index));
			}


		}

        private bool IsCinemaIdValid(string? id, ref Guid cinemaGuid)
        {
			// Non-existing parameter in the URL
			if (String.IsNullOrWhiteSpace(id))
			{
				return false;
			}

			// Invalid parameter in the URL
			bool isGuidValid = Guid.TryParse(id, out cinemaGuid);
			if (!isGuidValid)
			{
				return false;
			}

            return true;
		}
    }
}
