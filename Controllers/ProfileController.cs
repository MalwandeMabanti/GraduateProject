using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewProject.Models;
using System.Configuration;
using System.Net.Cache;

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
            //return View(context.Profile.ToArrayAsync());
            //return View(await context.Profile.ToListAsync());
            //var profile = context.Profile.ToListAsync();
            
            return View(await context.Profile.ToListAsync());
        }


        [HttpPost]
        public IActionResult Adding() {

        

            var information = HttpContext.Request.Form;

            context.Profile.Add(new ProfileViewModel()
            {

                FirstName = information["name"],
                Surname = information["lname"],
                DateOfBirth = Convert.ToDateTime(information["dob"]),
                //Age = int.Parse(information["country"]),
                Age = int.Parse(information["age"]),
                Country = information["country"],
                City = information["city"]


            });  ;

            context.SaveChanges();
            return new RedirectResult("/Profile");
            
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var profile = context.Profile.Find(id) as ProfileViewModel;
            return View(profile);
        }



        [HttpPost]
        public IActionResult Edit()
        {

            var information = HttpContext.Request.Form;

            context.Profile.Update(new ProfileViewModel()
            {
                Id = int.Parse(information["id"]),
                FirstName = information["name"],
                Surname = information["lname"],
                DateOfBirth = Convert.ToDateTime(information["dob"]),
                Age = int.Parse(information["age"]),
                Country = information["country"],
                City = information["city"]               
            });
            context.SaveChanges();
            return new RedirectResult("/Profile");

        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var profile = context.Profile.Find(id) as ProfileViewModel;
            return View(profile);


        }

        [HttpPost]
        public IActionResult Delete()
        {

            var information = HttpContext.Request.Form;

            context.Profile.Remove(new ProfileViewModel()
            {
                Id = int.Parse(information["id"]),
                FirstName = information["name"],
                Surname = information["lname"],
                DateOfBirth = Convert.ToDateTime(information["dob"]),
                Age = int.Parse(information["age"]),
                Country = information["country"],
                City = information["city"]
            });
            context.SaveChanges();
            return new RedirectResult("/Profile");

        }


    }
}
