using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logins;

namespace CarTracker.WebMvcApp.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; internal set; }

        public LoginViewModel(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
