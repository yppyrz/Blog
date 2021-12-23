using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Category
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<Post> CategoryPosts { get; set; }
    }
}
