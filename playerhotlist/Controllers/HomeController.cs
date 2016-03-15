using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace playerhotlist.Controllers
{
    public class HomeController : Controller
    {
        DbRepository repository = new DbRepository();

        public ActionResult Index()
        {
            return View(repository.GetAllItems());
        }
    }
}
