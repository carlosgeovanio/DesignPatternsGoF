#region AbstractFactory
// Usando SQL Server
using DesignPatternsGoF.Creational.AbstractFactory;

string sqlConnectionString = "Server=myServerAddress;Database=myDataBase;User=myUsername;Password=myPassword;";
IDbConnectionFactory sqlFactory = new SqlConnectionFactory(sqlConnectionString);
DatabaseClient sqlClient = new DatabaseClient(sqlFactory);
sqlClient.UseDatabase();

// Usando MySQL
string mysqlConnectionString = "Server=myServerAddress;Database=myDataBase;User=myUsername;Password=myPassword;";
IDbConnectionFactory mysqlFactory = new MySqlConnectionFactory(mysqlConnectionString);
DatabaseClient mysqlClient = new DatabaseClient(mysqlFactory);
mysqlClient.UseDatabase();
#endregion