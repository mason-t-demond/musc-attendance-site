using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MUSCAttendance.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [Display(Name = "Event Type")]
        public EventType EventType { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}