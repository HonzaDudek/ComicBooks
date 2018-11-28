using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET
        public ActionResult Index()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return Content("Hello from ComicBookController");
        }
    }
}