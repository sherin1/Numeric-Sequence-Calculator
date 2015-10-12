using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAPI.Tests.Controllers
{
    using System.Linq;

    using WebAPI.Controllers;

    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void Test_Positive()
        {
            var controller = new OddController();
            var t = controller.Get(10);

            Assert.AreEqual(1, t.ElementAt(0));
            Assert.AreEqual(3, t.ElementAt(1));
            Assert.AreEqual(5, t.ElementAt(2));
            Assert.AreEqual(7, t.ElementAt(3));
            Assert.AreEqual(9, t.ElementAt(4));
        }
    }
}
