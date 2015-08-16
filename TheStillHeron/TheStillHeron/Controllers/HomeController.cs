using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheStillHeron.Models;

namespace TheStillHeron.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ContactViewModel model = new ContactViewModel();
            model.EmailAddress = Properties.Settings.Default.EmailAddress;
            model.LinkedInUrl = Properties.Settings.Default.LinkedInUrl;
            return View(model);
        }
    }
}