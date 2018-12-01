using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class DependencyInjectionTest
    {
        private Mock<IClock> clock;

        [TestInitialize]
        public void TestInitialization()
        {
            clock = new Mock<IClock>();
            clock.SetupGet(p => p.Date).Returns(new DateTime(2012, 12, 12, 0, 0, 0));
        }

        [TestMethod]
        public void VerifyDobIsCorrect()
        {
            DependencyInjection instance = new DependencyInjection(clock.Object);
            DateTime dob = new DateTime(2012, 12, 11, 0, 0, 0);
            Assert.IsTrue(instance.IsValid(dob));
        }

        [TestMethod]
        public void VerifyDobIsNotCorrect()
        {
            DependencyInjection instance = new DependencyInjection(clock.Object);
            DateTime dob = new DateTime(2012, 12, 13, 0, 0, 0);
            Assert.IsFalse(instance.IsValid(dob));
        }
    }
}
