using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostDetailViewModel
    {
        public string PostContent { get; set; }
        public string PostTitle { get; set; }
        public string PostAuthorName { get; set; }
        public Category PostCategory { get; set; }
        public List<Comment> PostComments { get; set; }
        public List<Tag> PostTags { get; set; }

        public DateTime PostPublishDate { get; set; }
    }
}
