using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Tag
    {
        public string TagID { get; set; }
        public string TagName { get; set; }

        public List<Post> TagPosts { get; set; }
    }
}
