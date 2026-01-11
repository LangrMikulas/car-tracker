using CarTracker.WebMvcApp.Entities;

namespace CarTracker.WebMvcApp.ViewModels
{
    public class ZasilkovnaDataViewModel
    {
        public List<Car> cars { get; set; }
        public List<User> users { get; set; }

        public ZasilkovnaDataViewModel(List<Car> cars, List<User> users)
        {
            this.cars = cars;
            this.users = users;
        }
    }
}
