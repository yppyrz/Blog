using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class CommentRepository
    {
        private readonly BlogDbContext _db;

        public CommentRepository()
        {
            _db = new BlogDbContext();
        }

        public void AddComment(Comment comment)
        {
            _db.Comments.Add(comment);
            _db.SaveChanges();
        }
    }
}
