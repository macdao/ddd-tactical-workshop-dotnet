namespace Content.Domain.Model.Article
{
    public class Product
    {
        public Product(string code, string name)
        {
            Name = name;
            Code = code;
        }

        public string Code { get; }
        public string Name { get; }
    }
}
