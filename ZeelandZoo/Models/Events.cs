using System.ComponentModel.DataAnnotations;

namespace ZeelandZoo.Models
{
    public class Events
    {
        public int Id { get; set; }

        [Required]
       public string? Name { get; set; }
       
       public string? Description { get; set; }
        
        [Required]
       public DateTime? EventDate { get; set;}
       public decimal? EventPrice { get; set; }
       public int? EventAttendanceLimit { get; set; }

    }
}
