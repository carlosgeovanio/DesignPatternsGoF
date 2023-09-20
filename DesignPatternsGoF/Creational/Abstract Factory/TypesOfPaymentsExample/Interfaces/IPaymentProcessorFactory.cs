namespace DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces
{
    // Abstract Factory: Interface para a fábrica de processadores de pagamento
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CreatPaymentProcessor();
    }
}
