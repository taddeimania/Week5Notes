using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2MVC.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BlogPostId { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}