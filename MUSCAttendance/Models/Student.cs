using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MUSCAttendance.Pages.Courses;
using MUSCAttendance.Pages.Instructors;

namespace MUSCAttendance.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }


        [Required]
        [Display(Name = "Graduation Year")]
        public int GraduationYear { get; set; }

        [Required]
        [Display(Name = "Total Attendances")]
        public int TotalAttendances { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Attendance> Attendances { get; set; }

        public List<Course> Courses { get; set; }
    }
}