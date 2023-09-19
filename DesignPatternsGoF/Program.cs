using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Factories;
using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Interfaces;
using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Factories;
using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Interfaces;
using DesignPatternsGoF.Creational.AbstractFactory.TypesOfPaymentsExample.Services;

#region Creational

#region Abstract Factory (DBConnectionExample)

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

#region Abstract Factory (TypesOfPaymentsExample)
// Usando a fábrica de processadores de cartão de crédito
IPaymentProcessorFactory creditCardFactory = new CreditCardPaymentProcessorFactory();
PaymentService creditCardPaymentService = new PaymentService(creditCardFactory);
creditCardPaymentService.ProcessPayment(100m);

// Usando a fábrica de processadores de boleto
IPaymentProcessorFactory boletoFactory = new BoletoPaymentProcessorFactory();
PaymentService boletoPaymentService = new PaymentService(boletoFactory);
boletoPaymentService.ProcessPayment(150.0m);
#endregion

#endregion Creational
