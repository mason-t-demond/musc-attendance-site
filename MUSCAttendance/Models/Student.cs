namespace MUSCAttendance.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime GradYear { get; set; }

        public ICollection<Attendance> Attendances { get; set; }
    }
}