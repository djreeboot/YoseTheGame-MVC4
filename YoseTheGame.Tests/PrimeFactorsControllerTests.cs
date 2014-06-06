using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YoseTheGame.Controllers;

namespace YoseTheGame.Tests
{
    [TestClass]
    public class PrimeFactorsControllerTests
    {
        private PrimeFactorsController _controller;

        [TestInitialize]
        public void ThisController()
        {
            _controller = new PrimeFactorsController();
        }

        [TestMethod]
        public void ReturnsJson()
        {
            ActionResult result = _controller.Index();
            Assert.AreSame(result.GetType(), typeof(JsonResult));
        }

        /*[TestMethod]
        public void ReturnsTheExpectedJsonFor2()
        {
            ActionResult result = _controller.Index();
            var json = (JsonResult)result;
            Assert.IsTrue(json.Data.ToString() == "{ alive = True }");
        }

        [TestMethod]
        public void ReturnsTheExpectedJsonFor16()
        {
            ActionResult result = _controller.Index();
            var json = (JsonResult)result;
            Assert.IsTrue(json.Data.ToString() == "{ alive = True }");
        }*/
    }
}
