using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YoseTheGame.Controllers;

namespace YoseTheGame.Tests
{
    [TestClass]
    public class MinesweeperControllerTests
    {
        private MinesweeperController _controller;

        [TestInitialize]
        public void ThisController()
        {
            _controller = new MinesweeperController();
        }

        [TestMethod]
        public void IndexActionReturnsTheExpectedView()
        {
            ActionResult result = _controller.Index();
            var viewName = ((ViewResult)result).ViewName;
            Assert.IsTrue(viewName == "Minesweeper");
        }

        [TestMethod]
        public void DataActionReturnsJson()
        {
            ActionResult result = _controller.Data();
            Assert.AreSame(result.GetType(), typeof(JsonResult));
        }
    }
}
