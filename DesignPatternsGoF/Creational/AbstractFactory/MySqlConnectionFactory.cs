using MySql.Data.MySqlClient;
using System.Data;

namespace DesignPatternsGoF.Creational.AbstractFactory
{
    // Concrete implementation for connecting to MySQL
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        private string connectionString;
        public MySqlConnectionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
