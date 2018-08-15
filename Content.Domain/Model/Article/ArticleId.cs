using System;

namespace Content.Domain.Model.Article
{
    public class ArticleId
    {
        public ArticleId()
        {
            Id = Guid.NewGuid();
        }

        public ArticleId(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

        protected bool Equals(ArticleId other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ArticleId) obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}