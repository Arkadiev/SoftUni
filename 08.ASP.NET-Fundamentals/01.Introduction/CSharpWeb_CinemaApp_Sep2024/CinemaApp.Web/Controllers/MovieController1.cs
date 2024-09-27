using CinemaApp.Data;
using CinemaApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CinemaApp.Web.Controllers
{
    public class MovieController1 : Controller
    {
        private readonly CinemaDbContext dbContext;

        public MovieController1(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Movie> allMovies = this.dbContext.Movies.ToList();

            return View(allMovies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }
    }
}
