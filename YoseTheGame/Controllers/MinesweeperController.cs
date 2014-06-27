using System.Web.Mvc;
using System.Collections.Generic;
using YoseTheGame.Worlds.Minesweeper;

namespace YoseTheGame.Controllers
{
    public class MinesweeperController : Controller
    {
        public ActionResult Index()
        {
            return View("Minesweeper");
        }

        public ActionResult Data()
        {
            return Json(MinesweeperWorker.GetRandomGrid(), JsonRequestBehavior.AllowGet);
        }

    }
}
