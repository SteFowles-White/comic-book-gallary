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