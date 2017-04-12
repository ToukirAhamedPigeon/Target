using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SchoolContext ob = new SchoolContext();
            List<Students> students = ob.students.ToList();
            return View(students);
        }
        public ActionResult Details(int id)
        {
            SchoolContext ob = new SchoolContext();
            Students student = ob.students.Single(stu => stu.Id == id);
            return View(student);
        }
    }
}