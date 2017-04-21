using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondMVC.Models;

namespace SecondMVC.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            List<Departments> dept;
            using (SchoolContext con = new SchoolContext())
            {
                dept = con.departmentCon.ToList();
            }
            return View(dept);
        }
        public ActionResult All()
        {
            List<Teachers> TechList;
            using (SchoolContext con = new SchoolContext())
            {
                TechList = con.teacherCon.ToList();
            }
            return View(TechList);
        }
        public ActionResult Department(int id)
        {
            Departments ob;
            List<Teachers> TechList;
            using (SchoolContext con = new SchoolContext())
            {
                TechList = con.teacherCon.Where(tech => tech.DepartmentId== id).ToList();
                 ob= con.departmentCon.Single(d => d.Id == id);
                ViewBag.Dept = (string)ob.Name+" Department";
            }
            return View(TechList);
        }
        public ActionResult Details(int id)
        {
            Departments ob;
            Teachers Teacher;
            using (SchoolContext con = new SchoolContext())
            {
                Teacher = con.teacherCon.Single(tech => tech.Id == id);
                ob = con.departmentCon.Single(d => d.Id == Teacher.DepartmentId);
                ViewBag.DepartmentName = ob.Name;
            }
            return View(Teacher);
        }
    }
}