namespace DesignPatternsGoF.Creational.Singleton
{
    public class Order
    {
        private Logger logger;

        public Order()
        {
            logger = Logger.GetInstance();
        }

        public void PlaceOrder(string product, int quantity)
        {
            // Lógica para registrar o pedido
            logger.Log($"Pedido: {quantity} unidades de {product}");
        }
    }
}
