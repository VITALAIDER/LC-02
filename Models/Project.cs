using System;

namespace LC_02.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
    }
}