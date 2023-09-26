using System.Data;
using System.Data.SqlClient;

namespace DesignPatternsGoF.Creational.AbstractFactory
{
    // Concrete implementation for connecting to SQL Server
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        private string connectionString;
        public SqlConnectionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
