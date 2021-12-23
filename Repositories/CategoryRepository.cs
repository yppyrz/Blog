using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class CategoryRepository
    {
        private readonly BlogDbContext _db;

        public CategoryRepository()
        {
            _db = new BlogDbContext();
        }

        public void AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
        }

        public List<Category> GetAllCategory()
        {
            return _db.Categories.ToList();
        }
    }
}
