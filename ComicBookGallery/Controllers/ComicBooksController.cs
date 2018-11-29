using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;
using ComicBookGallery.Repositories;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET
        public ActionResult Detail()
        {
           ComicBookRepository repo = new ComicBookRepository();

            return View(repo.getComicBook(1));
        }
    }
}