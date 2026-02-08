using System.ComponentModel.DataAnnotations;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;

namespace CarTracker.WebMvcApp.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        public int SelectedCarId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public List<Car> AvailableCars { get; set; }


    }
}
