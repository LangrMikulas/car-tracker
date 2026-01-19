using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTracker.WebMvcApp.Entities
{
    [Table ("Equipment")]
    public class Equipment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("brand")]
        public string Brand { get; set; }

        [Column("refillable")]
        public bool Refillable { get; set; }
    }
}
