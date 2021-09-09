using ComicBookGallery.Data;
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
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
            //makes array accessible through View's Model property
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);          
            return View(comicBook);
        }
    }
}



//TODO:
//Learn about other ActionResult types provided by MVC
//understand Return View()


//NOTES:
//Controller base class' View() method returns a ViewResult object from an action method

//Viewbag is an MVC object that lets you pass data from Controller to View
//    define properties in Controller, access them in the view

//Object initializer syntax:


//Strongly typed view is an MVC view that is Associated with a specific type
//    exposes model instance through its model property

//private fields should begin with an underscore and a lower case letter

//contructors are special methods used to instantiate instance members
//don't have return types and have the same name as the class

//url path = controller/action/id(optional)
