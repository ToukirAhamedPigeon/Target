using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecondMVC.Models
{
    [Table("Departments")]
    public class Departments
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public List<Teachers> Teachers { set; get; }
    }
}