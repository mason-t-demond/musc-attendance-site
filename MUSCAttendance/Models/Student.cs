using System.ComponentModel.DataAnnotations;

namespace MUSCAttendance.Models
{
    public class Student
    {
        [Display(Name = "Hendrix ID")]
        public int ID { get; set; }

        [Display(Name = "Last")]
        public string LastName { get; set; }

        [Display(Name = "First")]
        public string FirstMidName { get; set; }

        [Display(Name = "Year Graduating")]
        public int GradYear { get; set; }

        [Display(Name = "Total Logs")]
        public int TotalAttendances {
            get
            {
                return Attendances.Count;
            }
        }

        public ICollection<Attendance> Attendances { get; set; }
    }
}