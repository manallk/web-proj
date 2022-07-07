using Microsoft.AspNetCore.Mvc;

namespace xyz.Controllers
{
    public class aboutus : Controller
    {
        public IActionResult Index()
        {
            return View("aboutus");
        }
    }
}
