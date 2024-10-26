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

        public IActionResult BlogSil(int id)
        {
            var b = _context.Blogs.Find(id);
            _context.Blogs.Remove(b);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult BlogGetir(int id)
        {
            var bl = _context.Blogs.Find(id);   
            return View("BlogGetir" , bl);

        }

        public IActionResult BlogGuncelle(Blog b)
        {
            var blg = _context.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
