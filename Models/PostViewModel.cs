using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostViewModel
    {
        public string PostId { get; set; }
        public string PostTitle { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
