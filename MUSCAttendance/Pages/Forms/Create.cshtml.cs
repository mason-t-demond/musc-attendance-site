using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MUSCAttendance.Data;
using MUSCAttendance.Models;

namespace MUSCAttendance.Pages.Forms
{
    public class CreateModel : PageModel
    {
        private readonly MUSCAttendance.Data.SchoolContext _context;

        public CreateModel(MUSCAttendance.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Form Form { get; set; } = default!;

        [BindProperty]
        public string StudentId { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Find the student based on the provided StudentId
            var student = await _context.Students
                .Where(s => s.StudentID.ToString() == StudentId)
                .Include(s => s.Forms)
                .FirstOrDefaultAsync();

            if (student == null)
            {
                // Handle the case where the student is not found
                ModelState.AddModelError(nameof(StudentId), "Student not found.");
                return Page();
            }

            Form.Student = student;

            student.Forms.Add(Form);

            _context.Forms.Add(Form);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}