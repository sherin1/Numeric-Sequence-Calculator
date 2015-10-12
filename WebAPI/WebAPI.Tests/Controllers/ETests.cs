using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebAPI.Controllers;

namespace WebAPI.Tests.Controllers
{
    [TestClass]
    public class ETests
    {
        [TestMethod]
        public void Test_Positive()
        {
            var controller = new EController();

            var t = controller.Get(10);

            Assert.AreEqual(5, t.ElementAt(0));
            Assert.AreEqual(10, t.ElementAt(1));
        }

        [TestMethod]
        public void Test_Negative()
        {
            var controller = new EController();
            
            var t = controller.Get(-2);

            Assert.AreEqual(1, t.Count());

            Assert.AreEqual(5, t.ElementAt(0));
        }
    }
}
