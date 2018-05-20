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
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
                //return new RedirectResult("/");
            }

            return Content("Hello from the comic books controller");
            //return new ContentResult()
            //{
            //    Content = "Hello from the comic books controller"
            //};
        }
    }
}