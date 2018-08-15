using System.Collections.Generic;
using System.Linq;
using Content.Domain.Model.Article;

namespace Content.Adapter.Dictionary
{
    public class DictionaryArticleRepository : IArticleRepository
    {
        private readonly Dictionary<ArticleId, Article> _articles = new Dictionary<ArticleId, Article>();

        public Article Save(Article article)
        {
            _articles[article.Id] = article;
            return article;
        }

        public Article FindById(ArticleId articleId)
        {
            return _articles[articleId];
        }

        public List<Article> FindAll()
        {
            return _articles.Values.ToList();
        }
    }
}