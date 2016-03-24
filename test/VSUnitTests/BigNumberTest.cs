using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerLib;
namespace EulerUnitTests
{
    [TestClass]
    public class BigNumberTest
    {
        const long largePrime = 15485863;
        const long largeCompsite = 15485862;

        [TestMethod]
        public void LongIsPrime_Test()
        {
            Assert.IsTrue(3.IsPrime());
            Assert.IsFalse(100.IsPrime());
            Assert.IsTrue(BigNumber.IsPrime(largePrime));
            Assert.IsFalse(BigNumber.IsPrime(largeCompsite));
        }

        [TestMethod]
        public void LongLeastFactor_Test()
        {
            Assert.AreEqual(BigNumber.LeastFactor(largePrime), largePrime);
            Assert.AreEqual(BigNumber.LeastFactor(1L), 1L);
            Assert.AreEqual(BigNumber.LeastFactor(2L), 2L);
            Assert.AreEqual(BigNumber.LeastFactor(3L), 3L);
            Assert.AreEqual(BigNumber.LeastFactor(5L), 5L);
            Assert.AreEqual(BigNumber.LeastFactor(largeCompsite), 2);
            Assert.AreEqual(BigNumber.LeastFactor(121L), 11L);
        }

        [TestMethod]
        public void LongIsPalindrome_Test()
        {
            Assert.IsTrue(BigNumber.IsPalindrome(585L, 10));
            Assert.IsTrue(BigNumber.IsPalindrome(585L, 2));
            Assert.IsFalse(BigNumber.IsPalindrome(678, 10));
        }
    }
}
