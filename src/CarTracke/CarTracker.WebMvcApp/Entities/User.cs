using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTracker.WebMvcApp.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("username")]
        public string Username { get; set;}

        [Column("password_hash")]
        public string PasswordHash { get; set; }

        [Column("favourite_car")]
        [ForeignKey("favourite_car")]
        public Car FavouriteCar { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        



    }
}
