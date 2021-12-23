using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class PostRepository
    {
        private readonly BlogDbContext _db;

        public PostRepository()
        {
            _db = new BlogDbContext();
        }

        // Db'ye post ekle.
        public void AddPost(Post post)
        {
            _db.Posts.Add(post);
            _db.SaveChanges();
        }
        public void UpdatePost(Post post)
        {
            _db.Posts.Update(post);
            _db.SaveChanges();
        }
        // Db'deki tüm postları liste olarak çek.
        public List<Post> GetAllPost()
        {
            return _db.Posts.ToList();
        }

        // Id ile post bul.
        public Post Find(string id)
        {
            return _db.Posts.Find(id);
        } 

    }
}
