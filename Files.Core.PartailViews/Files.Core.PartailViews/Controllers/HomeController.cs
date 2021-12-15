using Files.Core.PartailViews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Files.Core.PartailViews.Repository;

namespace Files.Core.PartailViews.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly IFilms _films;
        public HomeController(IFilms ObjFilms)
        {
            _films = ObjFilms;
        }

        public IActionResult Index()
        {
            var Films = _films.ListofFilms();

            return View();
        }

        public IActionResult Details(int Id)
        {
            
            Films file = new Films();
            file.CarList = _films.ListofFilms().ToList();

            Films obj2 = file.GetCarById(Id);
            //return View(obj2);
            return PartialView("Detailspartial", obj2);
        }


    }
}
