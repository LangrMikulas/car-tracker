using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTracker.WebMvcApp.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}
        [Column("favourite_car")]
        [ForeignKey("FavouriteCarId")]
        public Car FavouriteCar { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }

        

    }
}
