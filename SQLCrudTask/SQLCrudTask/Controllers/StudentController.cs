using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQLCrudTask.Controllers
{
    public class StudentController : Controller
    {
        Database db = new Database();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = db.getAllStudents();
            return View(students);
        }
    }
}