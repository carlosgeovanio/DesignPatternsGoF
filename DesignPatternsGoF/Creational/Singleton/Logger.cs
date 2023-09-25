namespace DesignPatternsGoF.Creational.Singleton
{
    public class Logger
    {
        private static Logger instance;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
                // Configurações de inicialização, se necessário
            }
            return instance;
        }

        public void Log(string message)
        {
            // Lógica para registrar a mensagem de log
            Console.WriteLine($"Logging: {message}");
        }
    }
}
