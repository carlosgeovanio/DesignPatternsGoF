namespace DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Interfaces
{
    public interface IDatabaseConnectionFactory
    {
        IDatabaseConnection CreateConnection();
    }
}
