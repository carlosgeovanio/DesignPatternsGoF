#region Creational

#region Abstract Factory
using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Factories;
using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Interfaces;

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

#endregion Creational
