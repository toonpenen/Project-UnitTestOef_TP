using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses;

namespace UnitTest_TestClasses
{
    [TestFixture]
    public class Clock_Test
    {
        [Test]
        public void GetTimeOfDay_WhenCalled_ReturnsNight()
        {
            var testtime = new DateTime(2003, 1, 1, 2, 0, 0);
            var result = Clock.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Night"));
        }
        [Test]
        public void GetTimeOfDay_WhenCalled_ReturnsMorning()
        {
            var testtime = new DateTime(2003, 1, 1, 6, 0, 0);
            var result = Clock.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Morning"));
        }
        [Test]
        public void GetTimeOfDay_WhenCalled_ReturnsNoon()
        {
            var testtime = new DateTime(2003, 1, 1, 13, 0, 0);
            var result = Clock.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Noon"));
        }
        [Test]
        public void GetTimeOfDay_WhenCalled_ReturnsEvening()
        {
            var testtime = new DateTime(2003, 1, 1, 18, 0, 0);
            var result = Clock.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Evening"));
        }
    }
}
