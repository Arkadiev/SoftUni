using CinemaApp.Data;
using Microsoft.AspNetCore.Mvc;
using Cinema = CinemaApp.Data.Models.Cinema;

namespace CinemaApp.Web.Controllers
{
    public class CinemaController : Controller
    {
        private readonly CinemaDbContext dbContext;

        public CinemaController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
			IEnumerable<Cinema> cinemas = this.dbContext.Cinemas.ToArray();
        }
    }
}
