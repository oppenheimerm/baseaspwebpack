using Microsoft.AspNetCore.Mvc;
namespace baseaspnetwebpack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}