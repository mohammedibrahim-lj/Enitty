using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entity.Models
{
    public class StuSports
    {
        [Key()]
        [ForeignKey("studTab")]
        public int StudentID { get; set; }
        public String SportName { get; set; }
        public StudentTable studTab { get; set; }
        public List<TeachersTable> teachtab { get; set; }

    }
}