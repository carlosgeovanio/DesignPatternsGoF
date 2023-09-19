using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces;

namespace DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Processors
{
    public class BoletoPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processando pagamento por boleto: R${amount}");
        }
    }
}
