using System.Web.Mvc;
using YoseTheGame.Worlds.Start;

namespace YoseTheGame.Controllers
{
    public class PingController : Controller
    {
        public ActionResult Index()
        {
            return Json(new PingResponse(true), JsonRequestBehavior.AllowGet);
        }

    }
}
