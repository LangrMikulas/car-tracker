using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;
using Microsoft.AspNetCore.Mvc;

namespace CarTracker.WebMvcApp.Controllers.Logins
{
    public class LoginsController : Controller
    {
        public AppDbContext AppDbContext { get; set; }
        public List<Login> Logins { get; set; }
        public LoginsController()
        {
            AppDbContext = new AppDbContext();
            Logins = AppDbContext.Login.ToList();
        }
        public IActionResult Login()
        {
            return View(Logins);
        }
    }
}
