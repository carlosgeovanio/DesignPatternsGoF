using System.Text;

namespace DesignPatternsGoF.Creational.Builder.ProductExample
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(Product product, int quantity)
        {
            Items.Add(new OrderItem { Product = product, Quantity = quantity });
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(item => item.Product.Price * item.Quantity);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Order Details:");
            foreach (var item in Items)
            {
                sb.AppendLine($"{item.Product.Name} - Quantity: {item.Quantity} - Subtotal: {item.Product.Price * item.Quantity:C}");
            }
            sb.AppendLine($"Total: {CalculateTotal():C}");
            return sb.ToString();
        }
    }
}
