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
//using DesignPatternsGoF.Creational.Singleton;

//Order order = new Order();
//order.PlaceOrder("ProdutoA", 5);
#endregion

#endregion Creational Patterns

#region Behavioral Patterns

#region Chain of Responsibility
//using DesignPatternsGoF.Behavioral.ChainOfResponsibility;

//var request1 = new AuthenticationRequest
//{
//    Token = "abc123"
//};

//var request2 = new AuthenticationRequest
//{
//    UserName = "john_doe",
//    Password = "password123"
//};

//var request3 = new AuthenticationRequest
//{
//    IsBiometricAuthenticated = true
//};

//AuthenticationHandler tokenHandler = new TokenAuthenticationHandler();
//AuthenticationHandler usernamePasswordHandler = new UsernamePasswordAuthenticationHandler();
//AuthenticationHandler biometricHandler = new BiometricAuthenticationHandler();

//tokenHandler.SetNext(usernamePasswordHandler);
//usernamePasswordHandler.SetNext(biometricHandler);

//Console.WriteLine("Authenticating request1:");
//bool result1 = tokenHandler.Authenticate(request1);
//Console.WriteLine("Authentication result for request1: " + result1);
//Console.WriteLine();

//Console.WriteLine("Authenticating request2:");
//bool result2 = tokenHandler.Authenticate(request2);
//Console.WriteLine("Authentication result for request2: " + result2);
//Console.WriteLine();

//Console.WriteLine("Authenticating request3:");
//bool result3 = tokenHandler.Authenticate(request3);
//Console.WriteLine("Authentication result for request3: " + result3);
#endregion

#region Command
using DesignPatternsGoF.Behavioral.Command;

var emailService = new EmailService();
var smsService = new SMSService();

var emailCommand = new EmailCommand(emailService, "exemplo@email.com", "Olá, este é um e-mail de exemplo.");
var smsCommand = new SMSCommand(smsService, "+123456789", "Olá, este é um SMS de exemplo.");

var messageSender = new MessageSender();
messageSender.AddCommand(emailCommand);
messageSender.AddCommand(smsCommand);

messageSender.SendMessages();  // Isso envia e-mails e SMSs
#endregion

#endregion Behavioral Patterns