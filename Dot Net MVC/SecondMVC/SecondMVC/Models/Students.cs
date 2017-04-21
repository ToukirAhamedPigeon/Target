using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SecondMVC.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public int Class { set; get; }
        public string City { set; get; }
    }
}