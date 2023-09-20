namespace DesignPatternsGoF.Creational.AbstractFactory.DBConnectionExample.Interfaces
{
    public interface IDatabaseConnection
    {
        void Connect();
        void ExecuteQuery(string query);
        void Disconnect();
    }
}
