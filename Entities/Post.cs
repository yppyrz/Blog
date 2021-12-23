using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Post
    {
        public string PostID { get; set; } = Guid.NewGuid().ToString();
        public string PostContent { get; set; }
        public string PostTitle { get; set; }
        public string PostAuthorName { get; set; }

        public Category PostCategory { get; set; }
        public List<Comment> PostComments { get; set; }
        public List<Tag> PostTags { get; set; }

        public DateTime PostPublishDate { get; set; }

    }
}
