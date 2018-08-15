using System.Collections.Generic;

namespace Content.Domain.Model.Article
{
    public class Article
    {
        public Article()
        {
            Id = new ArticleId();
            Products = new List<Product>();
            Status = ArticleStatus.Draft;
        }

        public ArticleId Id { get; }

        public string Title { get; }

        public string Content { get; }

        public List<Product> Products { get; }

        public ArticleStatus Status { get; private set; }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void Publish()
        {
            Status = ArticleStatus.Published;
        }
    }

    public enum ArticleStatus
    {
        Draft,
        Published
    }
}