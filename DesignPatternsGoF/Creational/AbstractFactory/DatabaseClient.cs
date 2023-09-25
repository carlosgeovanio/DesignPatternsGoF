using System.Data;

namespace DesignPatternsGoF.Creational.AbstractFactory
{
    public class DatabaseClient
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public DatabaseClient(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public void UseDatabase()
        {
            IDbConnection connection = _connectionFactory.CreateConnection();
            Console.WriteLine($"Using {connection.GetType().Name} for database connection.");

            // Here, you would normally use a connection to interact with the database
        }
    }
}
