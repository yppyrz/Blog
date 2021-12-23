using Blog.Entities;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class PostService
    {
        PostRepository _postRepository;

        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void CreatePost(Post post)
        {
            if (string.IsNullOrEmpty(post.PostAuthorName))
            {
                throw new Exception("Yazar adı boş geçilemez.");
            }
            if (string.IsNullOrEmpty(post.PostTitle) || string.IsNullOrEmpty(post.PostContent))
            {
                throw new Exception();
            }
            if (post.PostCategory == null)
            {
                throw new Exception();
            }
            if (post.PostTags == null)
            {
                throw new Exception();
            }
            post.PostPublishDate = DateTime.Now;
            _postRepository.AddPost(post);
        }

        public List<Post> PublishPost()
        {
            var x = _postRepository.GetAllPost();
            x = x.OrderByDescending(x => x.PostPublishDate).ToList();
            return x;
        }


        // CategoryId ile bu kategoriye sahip tüm postları listele.
        public List<Post> FindCategory(string categoryId)
        {
            var result = _postRepository.GetAllPost().Where(x => x.PostCategory.CategoryID == categoryId);
            return result.ToList();
        }

        // TagId ile bu etikete sahip tüm postları listele.
        public List<Post> FindTags(string tagId)
        {
            var listPosts = new List<Post>();

            var result = _postRepository.GetAllPost();
            foreach (var item in result)
            {
                foreach (var tag in item.PostTags)
                {
                    if (tag.TagID == tagId)
                    {
                        listPosts.Add(item);
                        break;
                    }
                }
            }
            return listPosts;
        }

        // PostId ile posta ait tüm yorumları listele.
        public List<Comment> GetAllComment(string postId)
        {
            var commentList = new List<Comment>();
            var post = _postRepository.Find(postId);
            commentList = post.PostComments;
            return commentList;

        }

        // Post'a comment ekle
        public void AddComment(string postId, Comment comment)
        {
            var post =_postRepository.Find(postId);
            post.PostComments.Add(comment);
            _postRepository.UpdatePost(post);
        }

        // Post'a category ekle
        public void AddCategory(Post post, Category category)
        {
            post.PostCategory = category;
            _postRepository.UpdatePost(post);
        }

        // Post'a tag ekle.
        public void AddTag(Post post, Tag tag)
        {
            post.PostTags.Add(tag);
            _postRepository.UpdatePost(post);
        }
        // PostId ile post'un etkiketlerini listele.
        public List<Tag> FindPostsTag(string postId)
        {
            var post =_postRepository.Find(postId);
            var listTags = new List<Tag>(post.PostTags);
            return listTags;
        }
    }
}
