using System.Collections.Generic;

namespace Content.Domain.Model.Article
{
    public class Article
    {
        public Article(string title, string content, IEnumerable<Product> products)
        {
            Id = new ArticleId();
            Status = ArticleStatus.Draft;
            Title = title;
            Content = content;
            Products = new List<Product>(products);
        }

        public ArticleId Id { get; }

        public string Title { get; }

        public string Content { get; }

        public List<Product> Products { get; }

        public ArticleStatus Status { get; private set; }

        public void Publish()
        {
            Status = ArticleStatus.Published;
        }
    }

    public enum ArticleStatus
    {
        Draft,
        Published,
        Deleted
    }
}