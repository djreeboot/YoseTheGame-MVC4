using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YoseTheGame.Controllers;
using YoseTheGame.Worlds.Start;

namespace YoseTheGame.Tests
{
    [TestClass]
    public class PingControllerTests
    {
        private ActionResult _result;

        [TestInitialize]
        public void ThisController()
        {
            PingController controller = new PingController();
            _result = controller.Index();
        }

        [TestMethod]
        public void ReturnsJson()
        {
            Assert.AreSame(_result.GetType(), typeof(JsonResult));
        }

        [TestMethod]
        public void ReturnsTheExpectedJson()
        {
            var json = (PingResponse)((JsonResult)_result).Data;
            Assert.IsTrue(json.alive);
        }
    }
}
