using MUSCAttendance.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MUSCAttendance.Pages.Courses
{
    public class CreateModel : DepartmentNamePageModel
    {
        private readonly MUSCAttendance.Data.SchoolContext _context;

        public CreateModel(MUSCAttendance.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateDepartmentsDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var emptyCourse = new Course();

            if (await TryUpdateModelAsync<Course>(
                 emptyCourse,
                 "course",   // Prefix for form value.
                 s => s.CourseID, s => s.Title, s => s.EventDate, s => s.Type, s => s.Description, s => s.Performed))
            {
                _context.Courses.Add(emptyCourse);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PopulateDepartmentsDropDownList(_context, emptyCourse.DepartmentID);
            return Page();
        }
      }
}