using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LC_02.Models;

namespace LC_02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new ProjectContext())
            {
                var prof = new Professor()
                {
                    FirstName = "ProfessorName",
                    LastName = "ProfessorLasName",
                    Email = "prof@mail.com",
                    Students = new List<Student>()
                };
                ctx.Professors.Add(prof);
                var stud = new Student()
                {
                    FirstName = "StudentName",
                    LastName = "StudentLastName",
                    Email = "student@mail.com",
                    Title = "Dr.",
                    ProfessorId = prof.ProfessorId,
                    Projects = new List<Project>()
                };
                ctx.Students.Add(stud);
                prof.Students.Add(stud);
                ctx.Professors.AddOrUpdate(prof);
                var project = new Project()
                {
                    Title = "MyProjectTitle",
                    Description = "MyProjectDescription",
                    StartDate = DateTime.Today,
                    Student = stud
                };
                ctx.Projects.Add(project);
                stud.Projects.Add(project);
                ctx.Students.AddOrUpdate(stud);
                ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}