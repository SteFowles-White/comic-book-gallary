using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallary.Data;
using ComicBookGallary.Models;


namespace ComicBookGallary.Controllers
{
    public class ComicBookController: Controller
    {

        private ComicBookRespository _comicBookRepository = null;
        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRespository(
                
                );
        }

        //create an Action Result to return the list of Comic booked is the 
        //ComicBookRespository
        public ActionResult Index()
        {
            //assign the array of comic books to a variable
            var comicBooks = _comicBookRepository.GetComicBooks();
            //return the conmicbooks variable
            return View(comicBooks);
        }


        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }


            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook);

        }


    }
}