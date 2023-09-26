using System.Data;

namespace DesignPatternsGoF.Creational.AbstractFactory
{
    public class DatabaseClient
    {
        private readonly IDbConnectionFactory connectionFactory;
        public DatabaseClient(IDbConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public void UseDatabase()
        {
            IDbConnection connection = connectionFactory.CreateConnection();
            Console.WriteLine($"Using {connection.GetType().Name} for database connection.");

            // Here, you would normally use a connection to interact with the database
        }
    }
}
