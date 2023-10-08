using DesignPatternsGoF.Creational.FactoryMethod;

namespace DesignPatternsGoF.Tests.Creational.FactoryMethod
{
    [TestClass]
    public class FactoryMethodTests
    {
        [TestMethod]
        public void CreateReport_Monthly_ReturnsMonthlyReport()
        {
            // Arrange
            ReportFactory factory = new ReportFactory();

            // Act
            IReport monthlyReport = factory.CreateReport(ReportType.Monthly);

            // Assert
            Assert.IsInstanceOfType(monthlyReport, typeof(MonthlyReport));
        }

        [TestMethod]
        public void CreateReport_Annual_ReturnsAnnualReport()
        {
            // Arrange
            ReportFactory factory = new ReportFactory();

            // Act
            IReport annualReport = factory.CreateReport(ReportType.Annual);

            // Assert
            Assert.IsInstanceOfType(annualReport, typeof(AnnualReport));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateReport_InvalidType_ThrowsArgumentException()
        {
            // Arrange
            ReportFactory factory = new ReportFactory();

            // Act and Assert (Expecting ArgumentException)
            factory.CreateReport((ReportType)99);  // Using an invalid ReportType
        }
    }
}
