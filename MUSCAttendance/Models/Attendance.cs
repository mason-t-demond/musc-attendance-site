using System.ComponentModel.DataAnnotations;

namespace MUSCAttendance.Models
{
    public enum Type
    {
        Hendrix, UCA, Other
    }

    public class Attendance
    {
        public int StudentID { get; set; }

        [Display(Name = "Event Type")]
        public Type type { get; set; }
        public Student Student { get; set; }
    }
}