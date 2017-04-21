using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecondMVC.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Students> studentCon { set; get; }
        public DbSet<Departments> departmentCon { set; get; }
        public DbSet<Teachers> teacherCon { set; get; }
    }
}