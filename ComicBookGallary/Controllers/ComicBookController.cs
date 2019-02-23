using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallary.Models;


namespace ComicBookGallary.Controllers
{
    public class ComicBookController: Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                     {
                         new Artists() {Name = "Dan Slott", Role = "Script" },
                         new Artists() {Name = "Pencils", Role = "Humberto Ramos" },
                         new Artists() {Name = "Inks", Role = "Victor Olazaba" },
                         new Artists() {Name = "Colors", Role = "Edgar Delgado" },
                         new Artists() {Name = "Letters", Role = "Chris Eliopoulos" },
                     },

            };


            return View(comicBook);

        }


    }
}