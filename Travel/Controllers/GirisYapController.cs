using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
	public class GirisYapController : Controller
	{
		private readonly Context _context;

		public GirisYapController(Context context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(Admin ad)
		{
			// Doğrudan giriş işlemi gerçekleştiriliyor
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, ad.Kullanici)
			};

			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			var authProperties = new AuthenticationProperties
			{
				IsPersistent = false
			};

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

			// Oturum değişkenine kullanıcı adını kaydet
			HttpContext.Session.SetString("Kullanici", ad.Kullanici);

			return RedirectToAction("Index", "Admin");
		}

		public async Task<IActionResult> LogOut()
		{
			// Kullanıcıyı çıkış yaptır
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Login", "GirisYap");
		}
	}
}
