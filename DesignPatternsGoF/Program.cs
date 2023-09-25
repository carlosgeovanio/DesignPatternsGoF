#region Creational Patterns

#region AbstractFactory
//// Usando SQL Server
//using DesignPatternsGoF.Creational.AbstractFactory;

//string sqlConnectionString = "Server=myServerAddress;Database=myDataBase;User=myUsername;Password=myPassword;";
//IDbConnectionFactory sqlFactory = new SqlConnectionFactory(sqlConnectionString);
//DatabaseClient sqlClient = new DatabaseClient(sqlFactory);
//sqlClient.UseDatabase();

//// Usando MySQL
//string mysqlConnectionString = "Server=myServerAddress;Database=myDataBase;User=myUsername;Password=myPassword;";
//IDbConnectionFactory mysqlFactory = new MySqlConnectionFactory(mysqlConnectionString);
//DatabaseClient mysqlClient = new DatabaseClient(mysqlFactory);
//mysqlClient.UseDatabase();
#endregion

#region Builder
using DesignPatternsGoF.Creational.Builder;

var reportSections = new List<ReportSection>
{
    new ReportSection("Introduction", "This is the introduction section of the report."),
    new ReportSection("Data Analysis", "This section contains the analysis of the data."),
    new ReportSection("Conclusion", "In conclusion, the data analysis shows promising trends.")
};

var report = new ReportBuilder()
    .SetTitle("Sales Report")
    .SetAuthor("John Doe")
    .SetConclusion("Sales are increasing.")
    .SetSections(reportSections)
    .BuildReport();

// Display the created report
report.DisplayReport();
#endregion

#endregion Creational Patterns