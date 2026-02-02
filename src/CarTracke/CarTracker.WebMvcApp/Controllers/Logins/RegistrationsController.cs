using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarTracker.WebMvcApp.Controllers.Logins
{
    public class RegistrationsController : Controller
    {
        public AppDbContext AppDbContext { get; set; }
        public List<Registration> Registrations { get; set; }

        public List<Car> cars { get; set; }
        public RegistrationsController()
        {
            AppDbContext = new AppDbContext();
            Registrations = AppDbContext.Registration.ToList();
            cars = AppDbContext.Car.ToList();
        }
        public IActionResult Registration()
        {
            var cars = AppDbContext.Car.ToList();

            return View("~/Views/Logins/Registration.cshtml", cars);
        }
    }
}
