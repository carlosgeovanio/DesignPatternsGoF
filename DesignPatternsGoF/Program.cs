#region Creational Patterns

#region Abstract Factory
//using DesignPatternsGoF.Creational.AbstractFactory;

//string sqlConnectionString = "Server=myServerAddress;Database=myDataBase;User=myUsername;Password=myPassword;";
//IDbConnectionFactory sqlFactory = new SqlConnectionFactory(sqlConnectionString);
//DatabaseClient sqlClient = new DatabaseClient(sqlFactory);
//sqlClient.UseDatabase();

//string mysqlConnectionString = "Server=myServerAddress;Database=myDataBase;User=myUsername;Password=myPassword;";
//IDbConnectionFactory mysqlFactory = new MySqlConnectionFactory(mysqlConnectionString);
//DatabaseClient mysqlClient = new DatabaseClient(mysqlFactory);
//mysqlClient.UseDatabase();
#endregion

#region Builder
//using DesignPatternsGoF.Creational.Builder;

//var reportSections = new List<ReportSection>
//{
//    new ReportSection("Introduction", "This is the introduction section of the report."),
//    new ReportSection("Data Analysis", "This section contains the analysis of the data."),
//    new ReportSection("Conclusion", "In conclusion, the data analysis shows promising trends.")
//};

//var report = new ReportBuilder()
//    .SetTitle("Sales Report")
//    .SetAuthor("John Doe")
//    .SetConclusion("Sales are increasing.")
//    .SetSections(reportSections)
//    .BuildReport();

//// Display the created report
//report.DisplayReport();
#endregion

#region Factory Method
//using DesignPatternsGoF.Creational.FactoryMethod;

//string filePath = "path/to/file.json";
//string fileType = "json";  // Could be "xml" or "csv" as well

//IFileParser parser = FileParserFactory.CreateFileParser(fileType);
//parser.ParseFile(filePath);
#endregion

#region Prototype
//using DesignPatternsGoF.Creational.Prototype;

//var configurationManager = new ConfigManager();

//Console.WriteLine("Configuração para Desenvolvimento:");
//var devConfig = configurationManager.GetConfiguration("development");
//Console.WriteLine($"App Name: {devConfig.AppName}, Connection String: {devConfig.DatabaseConnectionString}");

//Console.WriteLine("\nConfiguração para Teste:");
//var testConfig = configurationManager.GetConfiguration("test");
//Console.WriteLine($"App Name: {testConfig.AppName}, Connection String: {testConfig.DatabaseConnectionString}");

//Console.WriteLine("\nConfiguração para Produção:");
//var prodConfig = configurationManager.GetConfiguration("production");
//Console.WriteLine($"App Name: {prodConfig.AppName}, Connection String: {prodConfig.DatabaseConnectionString}");
#endregion

#region Singleton
// Exemplo de uso
using DesignPatternsGoF.Creational.Singleton;

Order order = new Order();
order.PlaceOrder("ProdutoA", 5);
#endregion
#endregion Creational Patterns