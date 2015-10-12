using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebAPI.Controllers;

namespace WebAPI.Tests.Controllers
{
    [TestClass]
    public class CTests
    {
        [TestMethod]
        public void Test_Positive()
        {
            var controller = new CController();

            var t = controller.Get(10);

            Assert.AreEqual(3, t.ElementAt(0));
            Assert.AreEqual(6, t.ElementAt(1));
        }

        [TestMethod]
        public void Test_Negative()
        {
            var controller = new CController();
            
            var t = controller.Get(-2);

            Assert.AreEqual(1, t.Count());

            Assert.AreEqual(3, t.ElementAt(0));
        }
    }
}
