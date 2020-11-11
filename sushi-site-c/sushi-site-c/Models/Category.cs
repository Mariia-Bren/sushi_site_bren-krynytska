using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sushi_site_c.Models
{
    public class Category
    {[Key]
       
        public int id { get; set; }
        public string  Title { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }

    }
}