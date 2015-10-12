using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAPI.Tests.Controllers
{
    using System.Linq;

    using WebAPI.Controllers;

    [TestClass]
    public class FullSeriesTests
    {
        [TestMethod]
        public void Get_Positive()
        {
            FullSeriesController controller = new FullSeriesController();

            var actural = controller.Get(1500).ElementAt(1499);

            Assert.AreEqual(1500, actural);
        }

        [TestMethod]
        public void Get_Negative_Zero()
        {
            FullSeriesController controller = new FullSeriesController();

            var actural = controller.Get(-1).ElementAt(0);
            
            Assert.AreEqual(1, actural);
        }
    }
}
