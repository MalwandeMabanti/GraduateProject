using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class SubmissionController : Controller
    {

        private readonly MyDbContext context;

        public SubmissionController(MyDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        /*
        public IActionResult Adding()
        {

            var information = HttpContext.Request.Form;

            context.AddRange(new ProfileViewModel()
            {
                FirstName = information["name"],
                Surname = information[""],
            });



        }*/

    }
}
