using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Interfaces;

namespace DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Connections
{
    public class SqlServerConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Conectando ao SQL Server...");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executando consulta no SQL Server: {query}");
        }

        public void Disconnect()
        {
            Console.WriteLine("Desconectando do SQL Server...");
        }
    }
}
