using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppForTest.Tests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(3, MyMath.Sum(1, 2));

            Assert.AreNotEqual(3, MyMath.Sum(1, 1));
        }

        [TestMethod]
        public void TestSumFail()
        {
            Assert.AreEqual(2, MyMath.Sum(1, 2));
        }
    }
}
