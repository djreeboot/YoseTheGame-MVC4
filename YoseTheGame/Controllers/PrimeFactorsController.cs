using System.Web.Mvc;
using YoseTheGame.Worlds.PrimeFactors;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsController : Controller
    {
        public static string LastDecomposition = string.Empty;

        public ActionResult Index(string number)
        {
            if (Request != null)
            {
                string[] values = Request.QueryString["number"].Split(',');

                if (values.Length > 1)
                {
                    return Json(PrimeFactorsWorker.Decompose((object)values), JsonRequestBehavior.AllowGet);
                }
            }
            return Json(PrimeFactorsWorker.Decompose((object)number), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Form()
        {
            return View("PrimeFactors");
        }

        public void SetLastDecomposition(string value)
        {
            PrimeFactorsController.LastDecomposition = value;
        }
    }
}
