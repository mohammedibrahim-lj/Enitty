using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Entity.Models
{
    public class StuSports
    {
        [Key()]
        public int SportsID { get; set; }
        public String SportName { get; set; }
        public StudentTable studTab { get; set; }
    }
}