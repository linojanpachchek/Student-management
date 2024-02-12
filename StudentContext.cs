using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.DataContext
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) :base(options)
        {
            
        }

        public DbSet<StudentEntity> Students { get; set; }
    }
}
