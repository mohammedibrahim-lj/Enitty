using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Entity.Models
{
    public class TeachersTable
    {
        [Key()]
        public int TeacherID { get; set; }
        public String TeacherName { get; set; }
        public virtual StudentTable studentTables {get; set;}
        public virtual List<StuSports> studSports { get; set; }
    }
}