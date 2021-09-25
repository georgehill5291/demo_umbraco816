using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace George.Web.Controllers
{
    public class HomeController : BaseSurfaceController
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}