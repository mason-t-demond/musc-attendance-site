using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MUSCAttendance.Models
{
    public class Student
    {
        [Display(Name = "Hendrix ID")]
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Required]
        [Display(Name = "Graduation Year")]
        public int GradYear { get; set; }

        

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }

        public List<Form>? Forms { get; set; }
    }
}