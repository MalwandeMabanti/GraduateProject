using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class ProfileController : Controller
    {

        private readonly MyDbContext context;

        public ProfileController(MyDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await context.Profile.ToListAsync());
        }
    }
}
