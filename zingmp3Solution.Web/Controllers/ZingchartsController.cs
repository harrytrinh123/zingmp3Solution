using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zingmp3Solution.Web.Controllers
{
    public class ZingchartsController : Controller
    {
        // GET: ZingchartsController
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
