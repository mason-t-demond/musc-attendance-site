using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MUSCAttendance.Models;

namespace MUSCAttendance.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

    public DbSet<Form> Forms { get; set; }
    public DbSet<Student> Students { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Form>().ToTable(nameof(Form));
        modelBuilder.Entity<Student>().ToTable(nameof(Student));
      
    }
}
