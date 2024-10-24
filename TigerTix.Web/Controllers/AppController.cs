using Microsoft.AspNetCore.Mvc;

namespace TigerTix.Web.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
