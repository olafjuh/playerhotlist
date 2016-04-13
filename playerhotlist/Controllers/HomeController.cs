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

        public ActionResult Arma()
        {
            return View(repository.GetAllItems(1));
        }

        public ActionResult Aircav()
        {
            return View(repository.GetAllItems(2));
        }

        public ActionResult Counter()
        {
            return View(repository.GetAllItems(3));
        }

        public ActionResult Squad()
        {
            return View(repository.GetAllItems(4));
        }

        public ActionResult ActiveList(int i)
        {
            return View(repository.GetAllItems(i));
        }
        
        public ActionResult NewHotlistItem()
        {
            return View();
        }
    }
}
