using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zingmp3Solution.Web.Controllers
{
    public class FollowingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
