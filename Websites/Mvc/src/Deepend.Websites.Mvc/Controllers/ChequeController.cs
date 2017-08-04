using System.Web.Mvc;

namespace Deepend.Websites.Mvc.Controllers
{
    public class ChequeController : Controller
    {
        //
        // GET: /Cheque/

        public ActionResult Index(object id)
        {
           return View("Index", model: id);
        }

    }
}
