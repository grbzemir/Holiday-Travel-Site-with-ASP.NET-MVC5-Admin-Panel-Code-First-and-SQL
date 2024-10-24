using Microsoft.AspNetCore.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class BlogController : Controller
    {
        private readonly Context _context;
		BlogYorum by = new BlogYorum();
		public BlogController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var bloglar = _context.Blogs.ToList();
            by.Deger1 = _context.Blogs.ToList();
			by.Deger3 = _context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
			return View(by);
        }

       
        public IActionResult BlogDetay(int id)
        {
            //var blogbul = _context.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = _context.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = _context.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }


    }
}
