using ConsoleApp1.Fundamentals;
using NUnit.Framework;

namespace ConsoleApp1.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }
    }
}