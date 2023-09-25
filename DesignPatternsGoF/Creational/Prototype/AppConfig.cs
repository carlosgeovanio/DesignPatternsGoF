namespace DesignPatternsGoF.Creational.Prototype
{
    public class AppConfig
    {
        public string AppName { get; set; }
        public string DatabaseConnectionString { get; set; }

        public AppConfig Clone()
        {
            return (AppConfig)this.MemberwiseClone();
        }
    }
}
