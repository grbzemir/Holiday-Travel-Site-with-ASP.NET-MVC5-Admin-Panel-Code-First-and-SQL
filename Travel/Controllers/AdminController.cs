using Microsoft.AspNetCore.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class AdminController : Controller
    {
        //Dependy Injection
        private readonly Context _context;

        //ctor
        public AdminController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var degerler = _context.Blogs.ToList();
            return View(degerler);
        }


        [HttpGet]
        public IActionResult YeniBlog()
        {

            return View();

        }

        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            _context.Blogs.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
