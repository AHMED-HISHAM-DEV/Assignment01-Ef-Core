using Assignment01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment01.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMED-HISHAM;Database=Assignment01DB;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.ID);
                entity.Property(d => d.Name)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(d => d.HiringDate)
                      .HasColumnType("date");
            });

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
        }
    }
}
