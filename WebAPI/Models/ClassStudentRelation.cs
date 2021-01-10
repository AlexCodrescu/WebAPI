using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class ClassStudentRelation
    {
       [Key]
        public int StudentID { get; set; }
        
        public int ClassID { get; set; }
        
        public virtual Student Student { get; set; }
        
        public virtual Class Class { get; set; }
    }
}
