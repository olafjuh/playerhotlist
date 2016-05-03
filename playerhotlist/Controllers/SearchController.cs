using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace playerhotlist.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        DbRepository repository = new DbRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchResult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchResult(string searchString)
        {
            return View();
        }
    }
}
