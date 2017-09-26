using System.Data.Entity;

namespace LC_02.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}