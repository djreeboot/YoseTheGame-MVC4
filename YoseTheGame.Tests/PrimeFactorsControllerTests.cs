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
            ActionResult result = _controller.Index("2");
            Assert.AreSame(result.GetType(), typeof(JsonResult));
        }
    }
}
