using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    public class MalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
