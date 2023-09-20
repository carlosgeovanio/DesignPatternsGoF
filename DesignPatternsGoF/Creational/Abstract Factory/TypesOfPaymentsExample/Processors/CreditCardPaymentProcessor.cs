using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces;

namespace DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Processors
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processando pagamento por cartão de crédito: R${amount}");
        }
    }
}
