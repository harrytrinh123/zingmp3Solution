using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.WebApp.Models;
using zingmp3Solution.WebApp.Services;

namespace zingmp3Solution.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISongService _songService;
        public HomeController(ILogger<HomeController> logger, ISongService songService)
        {
            _logger = logger;
            _songService = songService;
        }

        [HttpGet("{songId}")]
        public IActionResult Index(int songId)
        {
            var song = _songService.Get(songId);
            ViewData.Model = song;
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
