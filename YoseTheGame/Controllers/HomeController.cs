using System.Web.Mvc;

namespace YoseTheGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Home");
        }

    }
}
