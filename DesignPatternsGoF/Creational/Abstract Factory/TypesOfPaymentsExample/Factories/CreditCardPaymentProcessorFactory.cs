using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces;
using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Processors;

namespace DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Factories
{
    public class CreditCardPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatPaymentProcessor()
        {
            return new CreditCardPaymentProcessor();
        }
    }
}
