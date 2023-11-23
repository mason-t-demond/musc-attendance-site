using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MUSCAttendance.Models
{
    public class Attendance
    {
        public int ID {get; set;}
        public Form Form { get; set; }
        public Student Student { get; set; }
    }
}