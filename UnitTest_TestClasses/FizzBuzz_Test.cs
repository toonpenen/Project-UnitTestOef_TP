using NUnit.Framework;
using System;
using TestClasses;

namespace UnitTest_TestClasses
{
    [TestFixture]
    public class FizzBuzz_Test
    {
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void FizzBuzz_WhenCalled_ReturnsFizzBuzz(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        [TestCase(21)]
        public void FizzBuzz_WhenCalled_ReturnsFizz(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        [TestCase(50)]
        public void FizzBuzz_WhenCalled_ReturnsBuzz(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        [TestCase(1)]
        public void FizzBuzz_WhenCalled_ReturnsInput(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo(input.ToString()));
        }
    }
}
