using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTracker.WebMvcApp.Entities
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("model")]
        public string Model { get; set; }
        [Column("nickname")]
        public string Nickname { get; set; }
        [Column("owner")]
        public string Owner { get; set; }
        [Column("color")]
        public string Color { get; set; }
        [Column("brand")]
        public string Brand { get; set; }
        [Column("bought_date")]
        public DateTime BoughtTime { get; set; }

    }
}
