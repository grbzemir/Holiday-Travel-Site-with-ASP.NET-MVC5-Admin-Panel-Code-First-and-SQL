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
            var degerler = _context.Blogs.OrderBy(b => b.ID).Take(4).ToList();
            return View(degerler);
        }

        public IActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = _context.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var deger = _context.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial3()
        {
            var deger = _context.Blogs.Take(10).ToList();
            return PartialView(deger);
        }


        public PartialViewResult Partial4()
        {
            var deger = _context.Blogs.OrderBy(b => b.ID).Take(3).ToList();
            return PartialView(deger);
        }


        public PartialViewResult Partial5()
        {
            var deger = _context.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }

    }
}
