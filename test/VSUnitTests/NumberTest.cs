using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerLib;
namespace EulerUnitTests
{
    [TestClass]
    public class NumberTest
    {
        const int largePrime = 15485863;
        const int largeCompsite = 15485862;

        [TestMethod]
        public void IsPrime_Test()
        {
            Assert.IsTrue(3.IsPrime());
            Assert.IsFalse(100.IsPrime());
            Assert.IsTrue(Number.IsPrime(largePrime));
            Assert.IsFalse(Number.IsPrime(largeCompsite));
        }

        [TestMethod]
        public void LeastFactor_Test()
        {
            Assert.AreEqual(Number.LeastFactor(largePrime), largePrime);
            Assert.AreEqual(Number.LeastFactor(1), 1);
            Assert.AreEqual(Number.LeastFactor(2), 2);
            Assert.AreEqual(Number.LeastFactor(3), 3);
            Assert.AreEqual(Number.LeastFactor(5), 5);
            Assert.AreEqual(Number.LeastFactor(largeCompsite), 2);
            Assert.AreEqual(Number.LeastFactor(121), 11);
        }

        [TestMethod]
        public void IsPalindrome_Test()
        {
            Assert.IsTrue(Number.IsPalindrome(585, 10));
            Assert.IsTrue(Number.IsPalindrome(585, 2));
            Assert.IsFalse(Number.IsPalindrome(678, 10));
        }

        [TestMethod]
        public void IsSquare_Test()
        {
            Assert.IsTrue(Number.IsSquare(36));
            Assert.IsTrue(Number.IsSquare(1296));
            Assert.IsTrue(Number.IsSquare(9216));

            Assert.IsFalse(Number.IsSquare(9217));
            Assert.IsFalse(Number.IsSquare(1295));
            Assert.IsFalse(Number.IsSquare(35));

            Assert.IsTrue(49.IsSquare());
            Assert.IsTrue(64.IsSquare());
            Assert.IsFalse(80.IsSquare());
            Assert.IsFalse(2.IsSquare());
        }
    }
}
