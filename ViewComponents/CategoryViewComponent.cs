using Blog.Models;
using Blog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents
{
    [ViewComponent (Name ="Category")]
    public class CategoryViewComponent:ViewComponent
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryViewComponent(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = _categoryRepository.GetAllCategory();
            var model = new List<CategoryViewModel>();

            foreach (var item in x)
            {
                var y = new CategoryViewModel
                {
                    CategoryId = item.CategoryID,
                    CategoryName = item.CategoryName
                };
                model.Add(y);
            }

            return View(await Task.FromResult(model));
            
        }
    }
}
