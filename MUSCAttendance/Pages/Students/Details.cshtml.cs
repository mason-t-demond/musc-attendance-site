using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MUSCAttendance.Data;
using MUSCAttendance.Models;

namespace MUSCAttendance.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolContext _context;

        public DetailsModel(SchoolContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public int TotalAttendances { get; set; }
        public int HendrixCount { get; set; }
        public int UCACount { get; set; }
        public int OtherCount { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .Include(s => s.Forms)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            HendrixCount = Student.Forms.Count(f => f.Type.ToString() == "Hendrix");
            UCACount = Student.Forms.Count(f => f.Type.ToString() == "UCA");
            OtherCount = Student.Forms.Count(f => f.Type.ToString() == "Other");



            // Sum the counts
            TotalAttendances = HendrixCount + Math.Min(UCACount, 10) + Math.Min(OtherCount, 10);

            if (Student == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
