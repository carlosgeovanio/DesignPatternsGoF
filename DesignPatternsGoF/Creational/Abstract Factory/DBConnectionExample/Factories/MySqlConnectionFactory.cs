using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Connections;
using DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Interfaces;

namespace DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Factories
{
    public class MySqlConnectionFactory : IDatabaseConnectionFactory
    {
        public IDatabaseConnection CreateConnection()
        {
            return new MySqlConnection();
        }
    }
}
