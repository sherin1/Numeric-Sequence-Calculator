using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebAPI.Controllers;

namespace WebAPI.Tests.Controllers
{
    [TestClass]
    public class ZTests
    {
        [TestMethod]
        public void Test_Positive()
        {
            var controller = new ZController();

            var t = controller.Get(30);

            Assert.AreEqual(15, t.ElementAt(0));
            Assert.AreEqual(30, t.ElementAt(1));
        }

        [TestMethod]
        public void Test_Negative()
        {
            var controller = new ZController();
            
            var t = controller.Get(-2);

            Assert.AreEqual(1, t.Count());

            Assert.AreEqual(15, t.ElementAt(0));
        }
    }
}
