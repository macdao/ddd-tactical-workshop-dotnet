using System;
using Content.Domain.Model.Article;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Content.Test.Domain.Model.Article
{
    [TestClass]
    public class ArticleIdTest
    {
        [TestMethod]
        public void ArtileId_with_same_id_should_be_equal()
        {
            var id1 = new ArticleId(new Guid("dddddddddddddddddddddddddddddddd"));
            var id2 = new ArticleId(new Guid("dddddddddddddddddddddddddddddddd"));
            Assert.AreEqual(id1, id2);
        }
    }
}