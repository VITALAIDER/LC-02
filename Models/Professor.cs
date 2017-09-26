using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LC_02.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public virtual List<Student> Students { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public List<Project> Projects { get; set; }
        public int ProfessorId { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
    }

    public class ProjectContext : DbContext
    {
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}