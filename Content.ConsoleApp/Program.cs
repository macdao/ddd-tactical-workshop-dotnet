using System;
using System.Collections.Generic;
using Content.Adapter.Dictionary;
using Content.Application;
using Content.Domain.Model.Article;

namespace Content.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var articleApplicationService = new ArticleApplicationService(new DictionaryArticleRepository());

            var article = new Article("An article title", "An article content",
                new List<Product> {new Product("002852", "招商财富宝A")});

            articleApplicationService.CreateArticle(article);

            articleApplicationService.Publish(article.Id);

            var articles = articleApplicationService.GetArticles();

            Console.WriteLine("Articles size is {0}", articles.Count);
            Console.WriteLine("Id is {0} and Status is {1}", articles[0].Id.Id, articles[0].Status);
        }
    }
}