using System.Collections.Generic;

namespace Content.Domain.Model.Article
{
    public interface IArticleRepository
    {
        Article Save(Article article);
        Article FindById(ArticleId articleId);
        List<Article> FindAll();
    }
}
