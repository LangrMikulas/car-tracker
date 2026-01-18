using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;

namespace CarTracker.WebMvcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

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
