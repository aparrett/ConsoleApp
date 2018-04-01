using ConsoleApp1.Fundamentals;
using NUnit.Framework;

namespace ConsoleApp1.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }
    }
}