﻿using System.Collections.Generic;

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
}