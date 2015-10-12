using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System.Numerics;
using WebAPI.Math;

namespace WebAPI.Tests.Controllers
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void TestNegativeAndZero()
        {
            Assert.AreEqual(Fibonacci.Get(-1), 1);
            Assert.AreEqual(Fibonacci.Get(0), 1);
        }

        [TestMethod]
        public void Test_Positive_Within_Ten()
        {
            Assert.AreEqual(Fibonacci.Get(5), 5);
            Assert.AreEqual(Fibonacci.Get(8), 21);
        }

        //reference: http://www.maths.surrey.ac.uk/hosted-sites/R.Knott/Fibonacci/fibtable.html
        [TestMethod]
        public void Test_Positive_Within_OneHundred()
        {
            
            Assert.AreEqual(Fibonacci.Get(47), 2971215073);
            
            var t = BigInteger.Parse("218922995834555169026");

            Assert.AreEqual(Fibonacci.Get(99), t);
        }

        [TestMethod]
        public void Test_Positive_ThreeHundred()
        {
            var t = BigInteger.Parse("222232244629420445529739893461909967206666939096499764990979600");

            Assert.AreEqual(Fibonacci.Get(300), t);
        }
    }
}
