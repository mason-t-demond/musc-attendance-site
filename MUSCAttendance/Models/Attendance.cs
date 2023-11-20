using System.ComponentModel.DataAnnotations;

namespace MUSCAttendance.Models
{
    public enum EventType
    {
        Hendrix, UCA, Other
    }

    public class Attendance
    {
        [Display(Name = "Log ID")]
        public int AttendanceID { get; set; }

        public Student Student { get; set; }

        [Display(Name = "Hendrix ID")]
        public int StudentID {
            get
            {
                return Student.ID;
            }
        }

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