using DesignPatternsGoF.Creational.Singleton;
using Moq;

namespace DesignPatternsUnit.Tests
{
    [TestClass]
    public class TestFoo
    {
        [TestMethod]
        public void Logger_GetInstance_ReturnsSameInstance()
        {
            // Arrange
            var logger1 = Logger.GetInstance();
            var logger2 = Logger.GetInstance();

            // Assert
            Assert.AreSame(logger1, logger2);
        }
    }
}
