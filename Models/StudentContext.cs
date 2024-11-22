using Microsoft.EntityFrameworkCore;

namespace Evaluation.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Education> Educations { get; set; }

    }
}
