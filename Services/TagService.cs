using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class TagService
    {
        TagRepository _tagRepository;

        public TagService(TagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

    }
}
