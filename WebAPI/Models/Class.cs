using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Class
    {
        
        public int ClassID { get; set; }
        
        public string Title { get; set; }
        
        public string Instructor { get; set; }
        
        public string Day { get; set; }
        
        public string Time { get; set; }

    }
}
