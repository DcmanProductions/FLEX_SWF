﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChaseLabs.Games.SWF.STDLib.Global;
using ChaseLabs.Games.SWF.STDLib.Lists;
using ChaseLabs.Games.SWF.STDLib.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_UI.Models;

namespace Web_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Play(int id)
        {
            GameFile file = GameFiles.Singleton.ElementAt(id);
            return View(file);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
