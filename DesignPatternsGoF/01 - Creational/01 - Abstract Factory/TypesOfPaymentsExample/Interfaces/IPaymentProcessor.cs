namespace DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
