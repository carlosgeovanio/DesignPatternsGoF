namespace DesignPatternsGoF.Creational.Singleton
{
    public interface ILogger
    {
        void ClearLogs();
        IEnumerable<string> GetLogs();
        void WriteLog(string message);
    }
}