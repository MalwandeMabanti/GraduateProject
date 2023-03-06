using Microsoft.AspNetCore.Mvc;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ProfileViewModel model = new ProfileViewModel();
            return View(model);
        }
    }
}
