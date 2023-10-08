using DesignPatternsGoF.Creational.FactoryMethod;

public class ReportFactory
{
    public IReport CreateReport(ReportType reportType)
    {
        switch (reportType)
        {
            case ReportType.Monthly:
                return new MonthlyReport();
            case ReportType.Annual:
                return new AnnualReport();
            default:
                throw new ArgumentException("Unsupported report type.");
        }
    }
}
