﻿using Microsoft.AspNetCore.Mvc;
using TP1_DOTNET.Models;

namespace TP1_DOTNET.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name =
            "movie 1"
            };
            List<Movie> movies = new List<Movie>()
{
new Movie{Name="movie 2"},
new Movie{Name="movie 3"},
};
            return View(movies);
        }
        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }

        [HttpGet("Movie/released/{year}/{month}")]
        public IActionResult ByRelease(int month, int year)
        {
            return Content("Released in "+ month + " in " + year);
        }

        public IActionResult Merge()
        {
            Movie movie = new Movie()
            {
                Name = "Incpetion"
            };
            List<Customer> customers = new List<Customer>()
        {
            new Customer{Name="CR7"},
            new Customer{Name="David"},
            new Customer{Name="amine"},
    };

            var viewModel = new MergeViewModel { movie = movie, customers = customers };

            return View(viewModel);
        }
    }
}
