using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zingmp3Solution.WebApp.Controllers
{
    public class ZingchartsController : Controller
    {
        // GET: ZingchartsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ZingchartsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZingchartsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZingchartsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZingchartsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZingchartsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZingchartsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZingchartsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
