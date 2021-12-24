using Blog.Entities;
using Blog.Models;
using Blog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostRepository _postRepository;
        private readonly CategoryRepository _categoryRepository;

        public HomeController(PostRepository postRepository, ILogger<HomeController> logger, CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _postRepository = postRepository;
            _logger = logger;
        }


        public IActionResult Index()
        {


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult asf()
        {
            return View();
        }
    }
}
