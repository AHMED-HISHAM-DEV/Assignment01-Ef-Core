using Assignment01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment01.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMED-HISHAM;Database=Assignment01Ef-Core;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.DepartmentId);
                entity.Property(d => d.DeptName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(d => d.Location)
                      .HasColumnType("varchar(100)");
            });
        }
    }
}
