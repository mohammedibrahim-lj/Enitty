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
        public virtual List<TeachersTable> teachers { get; set; }
        public virtual StuSports studentSports { get; set; }
        
    }
}