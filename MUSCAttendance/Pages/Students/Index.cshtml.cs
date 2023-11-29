using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MUSCAttendance.Data;
using MUSCAttendance.Models;

namespace MUSCAttendance.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly MUSCAttendance.Data.SchoolContext _context;

        public IndexModel(MUSCAttendance.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            AttendanceSort = sortOrder == "Forms.Count" ? "form_desc" : "Forms.Count";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Student> studentsIQ =  _context.Students
        .Include(s => s.Forms)
        .AsNoTracking();
            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstMidName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.LastName);
                    break;
                case "form_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Forms.Count);
                    break;
                case "Forms.Count":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Forms.Count);
                    break;
                case "Date":
                    studentsIQ = studentsIQ.OrderBy(s => s.GradYear);
                    break;
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.GradYear);
                    break;
                
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.LastName);
                    break;
            }

            var pageSize = Configuration.GetValue("PageSize", 4);
            Students = await PaginatedList<Student>.CreateAsync(
                studentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
