using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarTracker.WebMvcApp.Entities.Logs
{
    [Table("RepairLog")]
    public class RepairLog
    {
        
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } // Název opravy

        [Column("description")]
        public string Description { get; set; }

        [Column("repair_date", TypeName = "date")]
        public DateTime RepairDate { get; set; }

        [Column("repair_cost")]
        public decimal RepairCost { get; set; }

        // Vazby
        [Column("car_id")]
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
    
}
