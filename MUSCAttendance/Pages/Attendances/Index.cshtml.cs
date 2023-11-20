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
    public class IndexModel : PageModel
    {
        private readonly MUSCAttendance.Data.SchoolContext _context;

        public IndexModel(MUSCAttendance.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Attendance> Attendance { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Attendance = await _context.Attendances.ToListAsync();
        }
    }
}
