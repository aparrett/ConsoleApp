using ConsoleApp1.Fundamentals;
using NUnit.Framework;

namespace ConsoleApp1.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(null)]
        public void GetOutput_NumberIsNull_ThrowArgumentNullException(int number)
        {
            Assert.That(() => FizzBuzz.GetOutput(number), Throws.ArgumentNullException);
        }

        [Test]
        public void GetOutput_NumberIsDivisibleBy3and5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NumberIsDivisibleBy3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NumberIsDivisibleBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberIsNotDivisibleBy3or5_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(8);
            Assert.That(result, Is.EqualTo("8"));
        }
    }
}