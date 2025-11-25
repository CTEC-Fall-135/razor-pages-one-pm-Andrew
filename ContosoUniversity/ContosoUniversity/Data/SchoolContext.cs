using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    { // constructor accepting DbContextOptions
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options) 
        {
        }

        // DbSet properties for each entity
        public DbSet<Student> Students { get; set; } // represents the Students table
        public DbSet<Enrollment> Enrollments { get; set; } // represents the Enrollments table
        public DbSet<Course> Courses { get; set; } // represents the Courses table

        // configure the model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course"); // map Course entity to Course table
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment"); // map Enrollment entity to Enrollment table
            modelBuilder.Entity<Student>().ToTable("Student"); // map Student entity to Student table
        }
    }
}
