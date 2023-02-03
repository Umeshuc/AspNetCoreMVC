using Microsoft.AspNetCore.Mvc;

namespace Uc.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            
            return View();
        }

        public ViewResult Contactus()
        {
            return View("AboutUs");
        }
    }
}
