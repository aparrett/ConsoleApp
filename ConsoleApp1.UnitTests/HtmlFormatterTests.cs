using ConsoleApp1.Fundamentals;
using NUnit.Framework;

namespace ConsoleApp1.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseStingWithStrongTags()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
        }
    }
}
