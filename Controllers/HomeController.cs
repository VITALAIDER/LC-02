using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Web.Mvc;
using LC_02.Services.Infrastucture;
using LC_02.Services.Students;

namespace LC_02.Controllers
{
    public class HomeController : Controller
    {

        private readonly IStudentService studentService;
        public HomeController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public ActionResult Index()
        {
            var studentDto = new StudentDto();
            studentDto.Email = "addedEmail";
            studentDto.FirstName = "addedFirstName";
            studentService.AddNewStudent(studentDto);
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