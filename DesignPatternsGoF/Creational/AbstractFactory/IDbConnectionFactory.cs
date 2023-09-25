using System.Data;

namespace DesignPatternsGoF.Creational.AbstractFactory
{
    // Defines the Abstract Factory to create database connections
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
