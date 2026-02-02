using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CarTracker.WebMvcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
                // 1. èást - konfigurace cookies
            builder.Services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)   //konfigurace autentikace
                .AddCookie(options =>
                {
                    options.LoginPath = "/Logins/Login";
                    //options.LogoutPath = "/Logins/Logout";
                    //options.AccessDeniedPath = "/Logins/Denied";

                    options.Cookie.HttpOnly = true;
                    options.Cookie.SameSite = SameSiteMode.Lax;
                });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            // dùležité poøadí!!: 
            app.UseAuthentication();    // zapnutí autentizace, pokazde zkontroluje, zda jsem prihlasen a pravidla pro autorizaci //kdo jsme
            app.UseAuthorization();     // jaké role máme

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            //AppDbContext appDbContext = new AppDbContext();

            //List<Car> cars = new List<Car>();
            //List<User> users = new List<User>();

            //cars = appDbContext.Car.ToList();
            //users = appDbContext.User.ToList();

            //Console.WriteLine();


            app.Run();
        }
    }
}
