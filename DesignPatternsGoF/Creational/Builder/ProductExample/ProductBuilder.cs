namespace DesignPatternsGoF.Creational.Builder.ProductExample
{
    public class ProductBuilder
    {
        private Product product;
        public ProductBuilder(string name, string category, decimal price) {
            product = new Product
            {
                Name = name,
                Category = category,
                Price = price
            };
        }

        public ProductBuilder ApplyDiscount()
        {
            product.IsDiscounted = true;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }
}
