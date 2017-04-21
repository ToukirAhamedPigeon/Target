using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondMVC.Models;

namespace SecondMVC.Controllers
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
            List<Students> StuList;
            using (SchoolContext con=new SchoolContext())
            {
                StuList = con.studentCon.ToList();
            }
                return View(StuList);
        }
        public ActionResult Class(int Class)
        {
            List<Students> StuList;
            using (SchoolContext con = new SchoolContext())
            {
                StuList = con.studentCon.Where(stu=>stu.Class==Class).ToList();
                ViewBag.Class = "Class"+Class;
            }
            return View(StuList);
        }
        public ActionResult Details(int id)
        {
            Students Student;
            using (SchoolContext con = new SchoolContext())
            {
                Student = con.studentCon.Single(stu => stu.Id == id);
            }
            return View(Student);
        }
    }
}