using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity.Models
{
    public class StudentTable
    {
        [Key]
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int StudentAge { get; set; }
    }
}