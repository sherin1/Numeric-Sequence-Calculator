using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebAPI.Controllers;

namespace WebAPI.Tests.Controllers
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void Test_Positive()
        {
            var controller = new EvenController();
            var t = controller.Get(10);

            Assert.AreEqual(2, t.ElementAt(0));
            Assert.AreEqual(4, t.ElementAt(1));
            Assert.AreEqual(6, t.ElementAt(2));
            Assert.AreEqual(8, t.ElementAt(3));
            Assert.AreEqual(10, t.ElementAt(4));
        }

        [TestMethod]
        public void Test_Negative()
        {
            var controller = new EvenController();
            
            var t = controller.Get(-2);

            Assert.AreEqual(1, t.Count());

            Assert.AreEqual(2, t.ElementAt(0));
        }
    }
}
