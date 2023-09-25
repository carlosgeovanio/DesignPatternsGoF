namespace DesignPatternsGoF.Creational.Prototype
{
    public class ConfigManager
    {
        public static readonly AppConfig DefaultConfiguration = new AppConfig
        {
            AppName = "MyApp",
            DatabaseConnectionString = "DefaultConnectionString"
        };

        public AppConfig GetConfiguration(string environment)
        {
            var customConfig = DefaultConfiguration.Clone();
            switch (environment.ToLower())
            {
                case "development":
                    customConfig.DatabaseConnectionString = "DevConnectionString";
                    break;
                case "test":
                    customConfig.DatabaseConnectionString = "TestConnectionString";
                    break;
                case "production":
                    customConfig.DatabaseConnectionString = "ProdConnectionString";
                    break;
                default:
                    Console.WriteLine("Unknown environment. Using default configuration.");
                    break;
            }
            return customConfig;
        }
    }
}
