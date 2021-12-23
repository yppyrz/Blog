using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class TagRepository
    {
        private readonly BlogDbContext _db;

        public TagRepository()
        {
            _db = new BlogDbContext();
        }

        public void AddTag(Tag tag)
        {
            _db.Tags.Add(tag);
            _db.SaveChanges();
        }

        public List<Tag> GetAllTags()
        {
            return _db.Tags.ToList();
        }
    }
}
