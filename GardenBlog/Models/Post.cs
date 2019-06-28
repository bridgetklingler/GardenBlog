using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime TimeStamp { get; set; }
        public int PostTagId { get; set; }

        public virtual Category Category { get; set; }
        public virtual PostTag PostTag { get; set; }

    }
}
