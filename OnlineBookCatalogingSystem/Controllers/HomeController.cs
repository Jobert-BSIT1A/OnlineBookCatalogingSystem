using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineBookCatalogingSystem.Models;

namespace OnlineBookCatalogingSystem.Controllers
{
    public class HomeController : Controller
    {

        private static List<Book> books = new List<Book>
        {
            new Book
            {
                BookID = 1,
                Title = "1984",
                Author = "George Orwell",
                Description = "Dystopian novel",
                PublishYear = 1949,
                Genre = "Fiction",
                CoverImageUr1 = "https://example.com/1984.jpg"
            },
            new Book
            {
                BookID = 2,
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Description = "Fantasy adventure",
                PublishYear = 1937,
                Genre = "Fantasy",
                CoverImageUr1 = "https://example.com/hobbit.jpg"
            }
        };

        public ActionResult BookList()
        {
            return View(books);
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
