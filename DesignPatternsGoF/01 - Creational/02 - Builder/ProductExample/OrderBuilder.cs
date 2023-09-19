namespace DesignPatternsGoF.Creational.Builder.ProductExample
{
    public class OrderBuilder
    {
        private Order order = new Order();

        public OrderBuilder AddProduct(Product product, int quantity)
        {
            order.AddItem(product, quantity);
            return this;
        }

        public Order Build()
        {
            return order;
        }
    }
}
