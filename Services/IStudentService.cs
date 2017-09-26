using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using LC_02.Models;

namespace LC_02.Services
{
    public interface IStudentService
    {
        bool AddNewStudent(Student student);
    }
}