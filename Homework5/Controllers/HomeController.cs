using Homework5.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Homework5.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryEntities db = new LibraryEntities();

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {

            var books = new BooksVM
            {
                Authors = db.authors.ToList(),
                Types = db.types.ToList(),
                Books = db.books.ToList(),

            };
            return View(books);

        }

        [HttpPost]
        public ActionResult Index(string searchtext)
        {
            var books = new BooksVM
            {
                Authors = db.authors.Where(x => x.name.Contains(searchtext)).ToList(),
                Types = db.types.ToList(),
                Books = db.books.ToList(),
            };

            return View(books);
        }

    }


}


