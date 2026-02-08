using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CarTracker.WebMvcApp.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("username")]
        public string Username { get; set;}

        [Required]
        [Column("password_hash")]
        public string PasswordHash { get; set; }

        [Required]
        [Column("favourite_car")]
        public int FavouriteCarId { get; set; }

        [ForeignKey("FavouriteCarId")]
        public virtual Car? FavouriteCar { get; set; }

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; }
    }
}
