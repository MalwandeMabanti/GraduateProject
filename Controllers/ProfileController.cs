using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
