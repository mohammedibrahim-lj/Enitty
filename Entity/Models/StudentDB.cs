using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity.Models
{
    public class StudentDB : DbContext
    {
        public DbSet<StudentTable> StudTable { get; set; }
    }
}