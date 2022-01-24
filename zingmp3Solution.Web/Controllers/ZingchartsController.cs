using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Web.Services;

namespace zingmp3Solution.Web.Controllers
{
    public class ZingchartsController : Controller
    {
        private readonly ISongService _songService;
        public ZingchartsController(ISongService songService)
        {
            _songService = songService;
        }
        // GET: ZingchartsController
        public async Task<IActionResult> Index()
        {
            var top10ZingChart = await _songService.GetTop10ZingChart();
            ViewBag.Top10ZingChart = top10ZingChart;
            return View(ViewBag);
        }
    }
}
