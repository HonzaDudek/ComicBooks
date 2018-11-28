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
        public ActionResult Detail()
        {
            return View();
        }
    }
}