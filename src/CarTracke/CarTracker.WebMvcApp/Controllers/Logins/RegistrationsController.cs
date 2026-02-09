using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;
using CarTracker.WebMvcApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;

namespace CarTracker.WebMvcApp.Controllers.Logins
{
    public class RegistrationsController : Controller
    {
        private readonly AppDbContext AppDbContext;
        public List<Registration> Registrations { get; set; }

        public List<Car> cars { get; set; }
        public RegistrationsController(AppDbContext context)
        {
            AppDbContext = context;
            Registrations = AppDbContext.Registration.ToList();
            cars = AppDbContext.Car.ToList();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            //var cars = AppDbContext.Car.ToList();

            var viewModel = new CarTracker.WebMvcApp.ViewModels.RegistrationViewModel();

            viewModel.AvailableCars = AppDbContext.Car.ToList();

            return View("~/Views/Logins/Registration.cshtml", viewModel);
        }

        [HttpPost]
        public IActionResult RegisterUser(string firstName, string lastName, string username, string password, int favouriteCarId)
        {
            User newUser = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                PasswordHash = password,
            };

            AppDbContext.User.Add(newUser);
            AppDbContext.SaveChanges();

            
            return RedirectToAction("Login", "Logins"); 
        }

    }
}
