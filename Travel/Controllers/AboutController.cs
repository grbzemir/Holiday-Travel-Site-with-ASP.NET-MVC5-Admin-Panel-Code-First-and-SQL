using Microsoft.AspNetCore.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
	public class AboutController : Controller
	{

		//Dependy Injection!
		private readonly Context _context;

		public AboutController(Context context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var degerler = _context.Hakkimizdas.ToList();
			return View(degerler);
		}
	}
}
