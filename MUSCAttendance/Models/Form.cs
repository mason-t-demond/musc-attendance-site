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
        public int ID { get; set; }

        public Student Student { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [Display(Name = "Event Location")]
        public EventType Type { get; set; }

        public bool Performed { get; set; }


        [Display(Name = "Program?")]
        public bool HasProgram { get; set; }

        public string? OtherDescription { get; set; }


        public string? ProgramDescription { get; set; }

        public bool Approved { get; set; }
    }
}