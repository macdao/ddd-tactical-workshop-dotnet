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
        private readonly ArticleApplicationService _applicationService = new ArticleApplicationService(new DictionaryArticleRepository());
        // GET api/<controller>
        public IEnumerable<Article> Get()
        {
            return _applicationService.GetArticles();
        }

        // GET api/<controller>/5
        public Article Get(Guid id)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}