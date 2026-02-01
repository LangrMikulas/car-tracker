using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarTracker.WebMvcApp.Entities.Logins
{
    [Table("SystemRegistrations")]
    public class Registration
    {
       
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password_hash")]
        public bool PasswordHash { get; set; }

        [Column("favourite_car")]
        public int FavouriteCar { get; set; }

        [Column("reg_time")]
        public DateTime RegistrationTime { get; set; }
    }
}
