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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"}
                }
            };
            

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
