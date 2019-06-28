using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Models
{
    public class PostTag
    {
        public int PostTagID { get; set; }

        public virtual List<Post> PostList { get; set; }
        public virtual List<Tag> TagList { get; set; }

    }
}
