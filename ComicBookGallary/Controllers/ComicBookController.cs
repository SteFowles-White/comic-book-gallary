﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallary.Controllers
{
    public class ComicBookController: Controller
    {
        public ActionResult Detail()
        {

            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");

            }
            return Content("Hello From the Comic Book Controller");

        }

    }
}