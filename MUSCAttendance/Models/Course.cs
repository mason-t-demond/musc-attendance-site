using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MUSCAttendance.Models
{
    public enum EventType {
        Hendrix, UCA, Other, A, B, C, D, F
    }

    public class Course
    {   
        [Display(Name = "Log ID")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Event Title")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Event")]
        public DateTime EventDate { get; set; }

        public EventType Type { get; set; }

        public string Description { get; set; }

        [Display(Name = "Performed in Event?")]
        public string Performed { get; set; }

        public int DepartmentID { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
        public Department Department { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}