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
        public string StudentId { get; set; }


        public async Task OnGetAsync(string studentId)
        {
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
            }
        }
    }
}