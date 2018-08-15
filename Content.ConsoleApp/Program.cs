using System;
using Content.Adapter.Dictionary;
using Content.Application;
using Content.Domain.Model.Article;

namespace Content.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var article = new Article();
            article.AddProduct(new Product("002852", "招商财富宝A"));

            var articleApplicationService = new ArticleApplicationService(new DictionaryArticleRepository());
            articleApplicationService.CreateArticle(article);

            var articles = articleApplicationService.GetArticles();

            Console.WriteLine("Articles size is {0}", articles.Count);
            Console.WriteLine("Id is {0} and Status is {1}", articles[0].Id.Id, articles[0].Status);
        }
    }
}