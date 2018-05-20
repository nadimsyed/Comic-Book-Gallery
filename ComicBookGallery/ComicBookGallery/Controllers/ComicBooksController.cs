using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    //Controller classes and action methods (detail method below) need to be public for websites to use
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();
        }
    }
}