using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            
            

            return View(comicBook);
        }
    }
}



//TODO:
//Learn about other ActionResult types provided by MVC


//NOTES:
//Controller base class' View() method returns a ViewResult object from an action method

//Viewbag is an MVC object that lets you pass data from Controller to View
//    define properties in Controller, access them in the view

//Object initializer syntax:


//Strongly typed view is an MVC view that is Associated with a specific type
//    exposes model instance through its model property
