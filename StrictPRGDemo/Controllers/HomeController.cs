using StrictPRGDemo.Attributes;
using StrictPRGDemo.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrictPRGDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Normal()
        {
            AddUserVM model = new AddUserVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Normal(AddUserVM model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ImportModelState]
        public ActionResult Strict()
        {
            AddUserVM model = new AddUserVM();
            return View(model);
        }

        [HttpPost]
        [ExportModelState]
        public ActionResult Strict(AddUserVM model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Strict");
            }
            return RedirectToAction("Index");
        }
    }
}