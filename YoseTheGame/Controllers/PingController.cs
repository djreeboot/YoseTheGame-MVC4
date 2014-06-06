using System.Web.Mvc;

namespace YoseTheGame.Controllers
{
    public class PingController : Controller
    {
        public ActionResult Index()
        {
            return Json(new { alive = true }, JsonRequestBehavior.AllowGet);
        }

    }
}
