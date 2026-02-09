using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace CarTracker.WebMvcApp.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Required]
        [Column("username")]
        public string Username { get; set;}
        
        [Column("admin")]
        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        [Column("password_hash")]
        public string PasswordHash { get; set; }

        [AllowNull]
        [Column("favourite_car")]
        public int? FavouriteCarId { get; set; }

        [AllowNull]
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
