using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Students> students { set; get; }
    }
}