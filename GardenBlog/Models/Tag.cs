using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int PostTagId { get; set; }

        public virtual PostTag PostTag { get; set; }

    }
}
