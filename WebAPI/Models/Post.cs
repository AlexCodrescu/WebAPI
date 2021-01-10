using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Post
    {
        
        public int PostID { get; set; }
        
        public string Posts { get; set; }
        
        public int StudentID { get; set; }
        

        public virtual Student Student { get; set; }

    }
}
