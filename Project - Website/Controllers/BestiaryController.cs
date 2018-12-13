using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project___Website.Controllers
{
    public class BestiaryController : Controller
    {
        [HttpGet()]
        public ActionResult Bestiary()
        {
            return View();
        }
    }
}