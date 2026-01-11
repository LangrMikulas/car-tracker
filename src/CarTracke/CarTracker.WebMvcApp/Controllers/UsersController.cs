using System;
using System.Xml;
using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarTracker.WebMvcApp.Controllers
{
    public class UsersController : Controller
    {
        public AppDbContext AppDbContext { get; set; }
        public List<Car> Cars{ get; set; }
        public List<User> Users { get; set; }

        public UsersController()
        {
            AppDbContext = new AppDbContext();
            Cars = AppDbContext.Car.ToList();
            Users = AppDbContext.User.ToList();
        }

        public IActionResult All()
        {
            ZasilkovnaDataViewModel model = new ZasilkovnaDataViewModel(Cars, Users);
            return View(model);
        }
    }
}
