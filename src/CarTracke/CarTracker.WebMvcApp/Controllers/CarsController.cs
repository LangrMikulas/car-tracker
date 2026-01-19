using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarTracker.WebMvcApp.Controllers
{
    public class CarsController : Controller
    {

        public AppDbContext AppDbContext { get; set; }
        public List<Car> Cars { get; set; }

        public CarsController()
        {
            AppDbContext = new AppDbContext();
            Cars = AppDbContext.Car.ToList();
        }

        public IActionResult ShowCars()
        {
            return View(Cars);
        }
    }
}
