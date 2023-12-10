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
        public IList<Student> Student{get;set;}

        public async Task OnGetAsync(string searchString)
        {
            IQueryable<Student> studentsIQ =  _context.Students
            .Include(s => s.StudentID)
            .AsNoTracking();

            searchString = SearchID;

            if (!String.IsNullOrEmpty(searchString)) {
                studentsIQ = studentsIQ.Where(s => s.StudentID.ToString().Contains(searchString));
            }

            Student = await studentsIQ.ToListAsync();
            
            foreach (var student in Student)
            {
                foreach (var form in student) {
                    Form.add(form);
                };
            }

            
            
        }
    }
}