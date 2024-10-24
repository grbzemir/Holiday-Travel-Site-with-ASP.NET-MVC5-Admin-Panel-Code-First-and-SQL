using Microsoft.AspNetCore.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var degerler = _context.Blogs.ToList();
            return View(degerler);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Partial1()
        {
            return PartialView();
        }
    }
}
