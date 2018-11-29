using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue!Witness the final hours of Doctor Octopus' life and his one, " +
                                  "last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist("Script", "Dan Slott"),
                    new Artist("Pencils", "Humberto Ramos"),
                    new Artist("Inks", "Victor Olazaba"),
                    new Artist("Colors", "Edgar Delgado"),
                    new Artist("Letters", "Chris Eliopoulos")
                }
            };

            return View(comicBook);
        }
    }
}