using Blog.Models;
using Blog.Repositories;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents
{
    [ViewComponent(Name = "Post")]
    public class PostViewComponent:ViewComponent
    {
        private readonly PostRepository _postRepository;
        private readonly PostService _postService;

        public PostViewComponent(PostRepository postRepository, PostService postService)
        {
            _postRepository = postRepository;
            _postService = postService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = _postRepository.GetAllPost();
            var z = _postService.PublishPost();
            var model = new List<PostViewModel>();
            var q = z.Take(2);

            foreach (var item in q)
            {
                var y = new PostViewModel
                {
                    PostId = item.PostID,
                    PostTitle = item.PostTitle,
                    PublishDate = item.PostPublishDate
                };
                model.Add(y);
            }


            return View(await Task.FromResult(model));

        }
    }
}
