using System.Data;
using System.Data.SqlClient;

namespace DesignPatternsGoF.Creational.AbstractFactory
{
    // Concrete implementation for connecting to SQL Server
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        private string _connectionString;
        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
