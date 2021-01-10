using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Major
    {
        
        public int MajorID { get; set; }
        
        public string Majors { get; set; }
        
        public int MajorStudent { get; set; }
        

        public virtual Student Student { get; set; }


    }
}
