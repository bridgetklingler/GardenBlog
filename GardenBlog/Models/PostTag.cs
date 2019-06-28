using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Models
{
    public class PostTag
    {
        public int PostTagID { get; set; }

        public virtual Post Post { get; set; }
        public int PostId {get;set;}

        public virtual Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}
