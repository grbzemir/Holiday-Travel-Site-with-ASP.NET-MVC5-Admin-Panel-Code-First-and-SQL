using Microsoft.AspNetCore.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class BlogController : Controller
    {
        private readonly Context _context;

        public BlogController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bloglar = _context.Blogs.ToList();
            return View(bloglar);
        }

        public IActionResult BlogDetay(int id)
        {
            var blogbul = _context.Blogs.Where(x => x.ID == id).ToList();
            return View(blogbul);
        }
    }
}
