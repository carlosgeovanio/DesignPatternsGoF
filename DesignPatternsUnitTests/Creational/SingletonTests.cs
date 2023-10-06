using DesignPatternsGoF.Creational.Singleton;

namespace DesignPatternsGoF.Tests.Creational
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void Instance_ReturnsTheSameLoggerInstanceEveryTime()
        {
            var logger1 = Logger.Instance;
            var logger2 = Logger.Instance;

            Assert.AreEqual(logger1, logger2);
        }
    }
}
