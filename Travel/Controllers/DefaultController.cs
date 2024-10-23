using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class DefaultController : Controller
    {
        //Controller yapısına gelen isteklere göre işlem yapıp kullanıcıya View ile isteğe göre bilgileri geri döndüren metotlara verilen isimdir.
        public IActionResult Index()
        {
            return View();
        }
    }
}
