using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using playerhotlist.Models;

namespace playerhotlist.Controllers
{
    public class HotlistItemController : Controller
    {
        //
        // GET: /HostlistItem/
        DbRepository repository = new DbRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewHotlistItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewHotlistItem(HotlistItem hotlistItem)
        {
            if (ModelState.IsValid)
            {
                repository.SaveItem(hotlistItem);
                return RedirectToAction("Index", "Home", "Home");
            }
            else
            {
                return View(hotlistItem);
            }
        }

        public ActionResult Examine(int id)
        {
            return View(repository.GetHotlistItem(id));
        }

        public ActionResult EditHotlistItem(int id3)
        {
            return View(repository.GetHotlistItem(id3));
        }

        [HttpPost]
        public ActionResult EditHotlistItem(HotlistItem hotlistItem)
        {
            repository.EditItem(hotlistItem);

            return RedirectToAction("Index", "Home", "Home");
        }
    }
}
