using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;
using Microsoft.AspNetCore.Mvc;

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
        }
        public IActionResult Registration()
        {
            return View("~/Views/Logins/Registration.cshtml", cars);
        }
    }
}
