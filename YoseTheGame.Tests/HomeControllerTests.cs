using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YoseTheGame.Controllers;

namespace YoseTheGame.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        private ActionResult _result;

        [TestInitialize]
        public void ThisController()
        {
            HomeController controller = new HomeController();
            _result = controller.Index();
        }

        [TestMethod]
        public void ReturnsView()
        {
            Assert.AreSame(_result.GetType(), typeof(ViewResult));
        }

        [TestMethod]
        public void ReturnsTheExpectedView()
        {
            var viewName = ((ViewResult)_result).ViewName;
            Assert.IsTrue(viewName == "Home");
        }
    }
}
