using Microsoft.AspNetCore.Mvc;

namespace Uc.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Controller working";
        }
    }
}
