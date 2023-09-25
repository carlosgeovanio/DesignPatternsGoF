using MySql.Data.MySqlClient;
using System.Data;

namespace DesignPatternsGoF.Creational.AbstractFactory
{
    // Concrete implementation for connecting to MySQL
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        private string _connectionString;
        public MySqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
