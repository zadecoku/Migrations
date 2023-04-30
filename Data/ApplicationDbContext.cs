using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Migrations.Models;

namespace Migrations.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Proffesor> Proffesors { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            builder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    Name = "Finance",
                    DateCreated = DateTime.Now,
                },
                new Department
                {
                    Id = 2,
                    Name = "IT",
                    DateCreated = DateTime.Now,
                }
                );

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Employee1",
                    Gender = "Female",
                    PostalCode = "12345",
                    City = "Tirane",
                    DepartmentId = 1,
                },
                new Employee
                {
                    Id = 2,
                    Name = "Employee2",
                    Gender = "Male",
                    PostalCode = "99999",
                    City = "Tirane",
                    DepartmentId = 2,
                }
                );

            builder.Entity<Proffesor>().HasData(
                new Proffesor
                {
                    Id = 1,
                    Name = "Name1",
                    DepartmentId = 1,
                    BirthDate = new DateTime(1995, 05, 09, 9, 15, 0),
                },
                new Proffesor
                {
                    Id = 2,
                    Name = "Name2",
                    DepartmentId = 2,
                    BirthDate = new DateTime(1993, 02, 10, 9, 15, 0),
                }
                );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "Admin",
                },

                new IdentityRole
                {
                    Id = "2",
                    Name = "Student",
                    NormalizedName = "Student",
                },

                new IdentityRole
                {
                    Id = "3",
                    Name = "Proffesor",
                    NormalizedName = "Proffesor",
                },

                new IdentityRole
                {
                    Id = "4",
                    Name = "Other Employees",
                    NormalizedName = "Other Employees",
                }
            );
        }
    }

}