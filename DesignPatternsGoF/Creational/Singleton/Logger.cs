namespace DesignPatternsGoF.Creational.Singleton
{
    public class Logger
    {
        private static Logger? _instance;
        private List<string> _logs;

        private Logger() {
            _logs = new List<string>();
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
                _instance = new Logger();

            return _instance;
        }

        public void Log(string message)
        {
            _logs.Add($"[{DateTime.Now}] {message}");
        }

        public IEnumerable<string> GetLogs()
        {
            return _logs;
        }
    }
}
