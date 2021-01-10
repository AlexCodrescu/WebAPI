using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Student
    {
        
        public int StudentID { get; set; }
        
        public string Name { get; set; }
        
        public string ClassYear { get; set; }
        
        public string Status { get; set; }

    }
}
