using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Factories;
using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Interfaces;
using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Factories;
using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces;
using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Services;
using DesignPatternsGoF.Creational.Builder.ProductExample;

#region Creational

#region Abstract Factory (Database Connection)

// Exemplo de uso para criar uma conexão com o SQL Server.
IDatabaseConnectionFactory sqlServerFactory = new SqlServerConnectionFactory();
IDatabaseConnection sqlServerConnection = sqlServerFactory.CreateConnection();
sqlServerConnection.Connect();
sqlServerConnection.ExecuteQuery("SELECT * FROM Tabela");
sqlServerConnection.Disconnect();

// Exemplo de uso para criar uma conexão com o MySQL.
IDatabaseConnectionFactory mySqlFactory = new MySqlConnectionFactory();
IDatabaseConnection mySqlConnection = mySqlFactory.CreateConnection();
mySqlConnection.Connect();
mySqlConnection.ExecuteQuery("SELECT * FROM Tabela");
mySqlConnection.Disconnect();
#endregion

#region Abstract Factory (Types of Payments)
// Usando a fábrica de processadores de cartão de crédito
IPaymentProcessorFactory creditCardFactory = new CreditCardPaymentProcessorFactory();
PaymentService creditCardPaymentService = new PaymentService(creditCardFactory);
creditCardPaymentService.ProcessPayment(100m);

// Usando a fábrica de processadores de boleto
IPaymentProcessorFactory boletoFactory = new BoletoPaymentProcessorFactory();
PaymentService boletoPaymentService = new PaymentService(boletoFactory);
boletoPaymentService.ProcessPayment(150.0m);
#endregion

#region Builder (Product)
Product product1 = new ProductBuilder("Laptop", "Electronics", 1500)
    .ApplyDiscount()
    .Build();
Product product2 = new ProductBuilder("Mouse", "Electronics", 30.12m)
    .ApplyDiscount()
    .Build();

Console.WriteLine(product1.ToString());
Console.WriteLine(product2.ToString());

var order = new OrderBuilder()
    .AddProduct(product1, 2)
    .AddProduct(product2, 3)
    .Build();

Console.WriteLine(order.ToString());
#endregion

#endregion Creational
