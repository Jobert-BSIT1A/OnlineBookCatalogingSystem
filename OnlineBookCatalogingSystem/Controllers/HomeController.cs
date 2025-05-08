using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBookCatalogingSystem.Data;
using OnlineBookCatalogingSystem.Models;

namespace OnlineBookCatalogingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly OnlineBookCatalogingSystemContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(OnlineBookCatalogingSystemContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Home";
            var books = _context.Books.ToList();
            return View(books);
        }

        public ActionResult BookList()
        {
            ViewData["ActivePage"] = "BookList";
            var books = _context.Books.ToList(); // make sure you're passing data
            return View(books);
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
