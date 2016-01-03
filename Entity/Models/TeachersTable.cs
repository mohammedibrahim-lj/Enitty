using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity.Models
{
    public class TeachersTable
    {
        public int TeacherID { get; set; }
        public String TeacherName { get; set; }
        public List<StudentTable> studentTable {get; set;}
    }
}