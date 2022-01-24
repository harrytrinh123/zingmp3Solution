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
            var top5Cat1 = await _songService.GetTop5Cat(1);
            var top5Cat2 = await _songService.GetTop5Cat(2);
            var top5Cat3 = await _songService.GetTop5Cat(3);
            ViewBag.Top10ZingChart = top10ZingChart;
            ViewBag.Top5Cat1 = top5Cat1;
            ViewBag.Top5Cat2 = top5Cat2;
            ViewBag.Top5Cat3 = top5Cat3;
            return View(ViewBag);
        }
    }
}
