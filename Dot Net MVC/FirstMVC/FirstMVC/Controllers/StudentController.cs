using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult All()
        {
            List<Students> students;
            using (SchoolContext studentcon = new SchoolContext())
            {
                students = studentcon.studentCon.ToList();
            }
                return View(students);
        }
        public ActionResult Class(int Class)
        {
            List<Students> students;
            using (SchoolContext studentcon = new SchoolContext())
            {
                students = studentcon.studentCon.Where(stu=>stu.Class==Class).ToList();
            }
            return View(students);
        }
        public ActionResult Details(int id)
        {
            Students student;
            using (SchoolContext studentcon = new SchoolContext())
            {
                student = studentcon.studentCon.Single(stu => stu.Id == id);
            }
            return View(student);
        }
    }
}