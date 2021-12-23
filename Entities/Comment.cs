using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Comment
    {
        public string CommentID { get; set; }
        public string UserName { get; set; }
        public string CommentContent { get; set; }

        public Post CommentPost { get; set; }
        public DateTime CommentPublishDate { get; set; }
    }
}
