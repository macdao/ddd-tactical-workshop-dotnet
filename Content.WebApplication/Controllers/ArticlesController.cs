using System;
using System.Collections.Generic;
using System.Web.Http;
using Content.Adapter.Dictionary;
using Content.Application;
using Content.Domain.Model.Article;

namespace Content.WebApplication.Controllers
{
    public class ArticlesController : ApiController
    {
        private static readonly ArticleApplicationService ApplicationService =
            new ArticleApplicationService(new DictionaryArticleRepository());

        // GET api/<controller>
        public IEnumerable<Article> Get()
        {
            return ApplicationService.GetArticles();
        }

        // GET api/<controller>/5
        public Article Get(Guid id)
        {
            return ApplicationService.GetArticle(new ArticleId(id));
        }

        // POST api/<controller>
        public void Post(PostRequest request)
        {
            ApplicationService.CreateArticle(new Article(request.Title, request.Content, request.Products));
        }

        // PUT api/<controller>/5
        public void Put(Guid id, PutRequest request)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(Guid id)
        {
        }

        public class PostRequest
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public List<Product> Products { get; set; }
        }

        public class PutRequest
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public List<Product> Products { get; set; }
        }
    }
}