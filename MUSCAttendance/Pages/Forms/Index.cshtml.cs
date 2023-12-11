using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MUSCAttendance.Data;
using MUSCAttendance.Models;

namespace MUSCAttendance.Pages.Forms
{
    public class IndexModel : PageModel
    {
        private readonly MUSCAttendance.Data.SchoolContext _context;

        public IndexModel(MUSCAttendance.Data.SchoolContext context)
        {
            _context = context;
        }

        public string SearchID { get; set; }
        public IList<Form> Form { get;set; } = default!;
<<<<<<< HEAD
        public string StudentId { get; set; }
=======
        public IList<Student> Students {get;set;}
>>>>>>> b15030a38c02d9c8fe4c6bf3bc34df94369789f0


        public async Task OnGetAsync(string studentId)
        {
<<<<<<< HEAD
            // If a student ID is provided, filter forms by that ID
            if (!string.IsNullOrEmpty(studentId))
            {
                Form = await _context.Forms
                    .Where(f => f.Student.StudentID.ToString() == studentId)
                    .ToListAsync();
            }
            else
            {
                // If no student ID provided, retrieve all forms
                Form = await _context.Forms.ToListAsync();
=======
            IQueryable<Student> studentsIQ =  _context.Students
            .Include(s => s.StudentID)
            .AsNoTracking();

            searchString = SearchID;

            if (!String.IsNullOrEmpty(searchString)) {
                studentsIQ = studentsIQ.Where(s => s.StudentID.ToString().Contains(searchString));
>>>>>>> b15030a38c02d9c8fe4c6bf3bc34df94369789f0
            }

            Students = await studentsIQ.ToListAsync();
            foreach (var student in Students)
            {
                foreach (var form in student.Forms) {
                    Form.Add(form);
                };
            }

            
            
        }
    }
}