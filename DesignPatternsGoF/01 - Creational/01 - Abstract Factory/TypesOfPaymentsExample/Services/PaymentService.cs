using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces;

namespace DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Services
{
    public class PaymentService
    {
        private IPaymentProcessorFactory _paymentProcessorFactory;
        public PaymentService(IPaymentProcessorFactory factory)
        {
            _paymentProcessorFactory = factory;
        }

        public void ProcessPayment(decimal amount)
        {
            IPaymentProcessor paymentProcessor = _paymentProcessorFactory.CreatPaymentProcessor();
            paymentProcessor.ProcessPayment(amount);
        }
    }
}
