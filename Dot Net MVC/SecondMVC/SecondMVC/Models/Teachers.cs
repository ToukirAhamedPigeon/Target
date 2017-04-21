using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecondMVC.Models
{
    [Table("Teachers")]
    public class Teachers
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public int DepartmentId { set; get; }
        public string City { set; get; }
        public Departments Department { set; get; }
    }
}