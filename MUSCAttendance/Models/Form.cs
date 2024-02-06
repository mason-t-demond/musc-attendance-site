using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MUSCAttendance.Models
{
    public enum EventType
    {
        Hendrix, UCA, Other
    }

    public class Form
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public Student Student { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [Display(Name = "Event Location")]
        public EventType Type { get; set; }

        [Display(Name = "Performed in Event")]
        public bool Performed { get; set; }


        [Display(Name = "Event had Program")]
        public bool HasProgram { get; set; }

        [Display(Name = "Program URL")]
        public string? ProgramPhotoUrl { get; set; }
        
        [Display(Name = "Learning Goal Description")]
        public string? OtherDescription { get; set; }


        [Display(Name = "Event Description")]
        public string? ProgramDescription { get; set; }

        [Display(Name = "Approved")]
        public bool Approved { get; set; }
    }
}