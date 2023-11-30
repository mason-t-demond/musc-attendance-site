using MUSCAttendance.Data;
using MUSCAttendance.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MUSCAttendance.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;
        private readonly IConfiguration Configuration;

        public IndexModel(SchoolContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public string NameSort { get; set; }
        public string AttendanceSort { get; set; }
        public string DateSort { get; set; }

        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Student> Students { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
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
                                       || s.FirstMidName.Contains(searchString)
                                       || s.ID.ToString().Contains(searchString));
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