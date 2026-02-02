using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;

namespace CarTracker.WebMvcApp.ViewModels
{
    public class ZasilkovnaDataViewModel
    {
        public List<Car> cars { get; set; }
        public List<User> users { get; set; }
        public List<Registration> registrations { get; set; }

        public ZasilkovnaDataViewModel(List<Car> cars,  List<User> users, List<Registration> registrations)
        {
            this.cars = cars;
            this.users = users;
            this.registrations = registrations;
        }
    }
}
