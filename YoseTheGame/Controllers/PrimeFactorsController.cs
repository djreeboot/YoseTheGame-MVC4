using System.Web.Mvc;
using YoseTheGame.Worlds.PrimeFactors;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsController : Controller
    {
        public ActionResult Index(string number)
        {
            if (Request != null)
            {
                string[] values = Request.QueryString["number"].Split(',');

                if (values.Length == 1)
                    return Json(PrimeFactorsWorker.Decompose(number), JsonRequestBehavior.AllowGet);
                else
                    return Json(PrimeFactorsWorker.Decompose(values), JsonRequestBehavior.AllowGet);
            }

            return Json(PrimeFactorsWorker.Decompose(number), JsonRequestBehavior.AllowGet);
        }

    }
}
