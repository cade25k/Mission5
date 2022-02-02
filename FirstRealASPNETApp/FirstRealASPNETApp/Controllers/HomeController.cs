using FirstRealASPNETApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRealASPNETApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext mc)
        {
            _logger = logger;
            context = mc;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var ml = context.movies.Include(x => x.Category).ToList();
            return View(ml);
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.categories = context.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(Movie m)
        {
            if (ModelState.IsValid)
            {
                context.Add(m);
                context.SaveChanges();

                return View("Confirmation", m);
            }
            else
            {
                ViewBag.categories = context.categories.ToList();

                return View(m);
            }
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.categories = context.categories.ToList();
            var movie = context.movies.Single(x => x.MovieId == movieid);
            return View("NewMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            context.Update(m);
            context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = context.movies.Single(x => x.MovieId == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie m)
        {
            context.movies.Remove(m);
            context.SaveChanges();
            return RedirectToAction("MovieList");
        }
        public IActionResult Podcasts()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
