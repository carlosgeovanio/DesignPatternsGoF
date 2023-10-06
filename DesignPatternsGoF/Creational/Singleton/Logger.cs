namespace DesignPatternsGoF.Creational.Singleton
{
    public sealed class Logger : ILogger
    {
        private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());
        private readonly List<string> _logs = new();

        private Logger()
        {
        }

        public static Logger Instance = _lazyLogger.Value;

        public void WriteLog(string message)
        {
            _logs.Add($"[{DateTime.Now}] {message}");
        }

        public IEnumerable<string> GetLogs()
        {
            return _logs;
        }

        public void ClearLogs()
        {
            _logs.Clear();
        }
    }
}
