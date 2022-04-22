using Microsoft.EntityFrameworkCore;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Entity
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Employees> Employees { get; set; }
    }
}
