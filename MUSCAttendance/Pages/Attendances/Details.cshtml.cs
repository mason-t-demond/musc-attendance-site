using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MUSCAttendance.Data;
using MUSCAttendance.Models;

namespace MUSCAttendance.Pages.Attendances
{
    public class DetailsModel : PageModel
    {
        private readonly MUSCAttendance.Data.SchoolContext _context;

        public DetailsModel(MUSCAttendance.Data.SchoolContext context)
        {
            _context = context;
        }

        public Attendance Attendance { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendance = await _context.Attendances.FirstOrDefaultAsync(m => m.AttendanceID == id);
            if (attendance == null)
            {
                return NotFound();
            }
            else
            {
                Attendance = attendance;
            }
            return Page();
        }
    }
}
