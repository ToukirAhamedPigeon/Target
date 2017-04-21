using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    [Table("Departments")]
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teachers> TeacherId { get; set; }
    }
}