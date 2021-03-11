﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using BasicFilmDbProject.Models;

namespace BasicFilmDbProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult OneFilm()

        {

            Film model = _context.Films.FirstOrDefault();

            return View(model);

        }

        public IActionResult AllFilms()

        {

            List<Film> model = _context.Films.ToList();

            return View(model);

        }

        public IActionResult FilmDetails(int id)

        {

            Film model = _context.Films.Find(id);

            return View(model);

        }

        public IActionResult Search(String SearchString)

        {

            if (!string.IsNullOrEmpty(SearchString))

            {


                var films = from m in _context.Films

                            where m.FilmTitle.Contains(SearchString)

                            select m;

                List<Film> model = films.ToList();

                ViewData["SearchString"] = SearchString;

                return View(model);

            }
            else
            {
                return View();
            }



        }




        public IActionResult Index()
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
