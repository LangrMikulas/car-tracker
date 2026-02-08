using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;
using CarTracker.WebMvcApp.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarTracker.WebMvcApp.Controllers.Logins
{
    public class LoginsController : Controller
    {
        private readonly AppDbContext AppDbContext;
        //public List<Login> Logins { get; set; }
        public LoginsController(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
            
        }
        //[HttpGet]
        //public IActionResult Login(string username, string password)
        //{
        //    LoginViewModel model = new LoginViewModel(username, password);
        //    return View(Logins);
        //}

        [HttpGet]
        public IActionResult Register() => View();

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // 1. zda-li user existuje
            User? user = AppDbContext.User
                .FirstOrDefault(u => u.Username == model.Username && u.PasswordHash == HashPassword(model.Password));
            if (user == null)
            {
                return View(model);
            }

            // 2. sestavit identitu/totožnost usera pomocí 
            List<Claim> claims = new List<Claim>();


            Claim usernameClaim = new Claim("username", user.Username);
            //Claim firstNameClaim = new Claim("first_name", user.FirstName);
            //Claim lastNameClaim = new Claim("last_name", user.LastName);

            claims.Add(usernameClaim);
            //claims.Add(firstNameClaim);
            //claims.Add(lastNameClaim);

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Index", "Home");
        }
        private string HashPassword(string PasswordHash)
        {
            return PasswordHash;
        }

        public async Task<IActionResult> Logout()
        {
            //smazani kukis
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); 

            return RedirectToAction( "Login", "Logins");
        }
    }
}
