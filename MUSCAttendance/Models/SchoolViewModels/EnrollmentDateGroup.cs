using System;
using System.ComponentModel.DataAnnotations;

namespace MUSCAttendance.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? GraduationYear { get; set; }

        public int StudentCount { get; set; }
    }
}