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
    public class DeleteModel : PageModel
    {
        private readonly MUSCAttendance.Data.SchoolContext _context;

        public DeleteModel(MUSCAttendance.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Form Form { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var form = await _context.Forms.FirstOrDefaultAsync(m => m.ID == id);

            if (form == null)
            {
                return NotFound();
            }
            else
            {
                Form = form;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var form = await _context.Forms.FindAsync(id);
            if (form != null)
            {
                Form = form;
                _context.Forms.Remove(Form);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}