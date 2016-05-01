using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using playerhotlist.Models;

namespace playerhotlist.Controllers
{
    [Authorize]
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
            NewHotlistItemViewModel vm = new NewHotlistItemViewModel();
            IEnumerable<GameTypes> actionTypes = Enum.GetValues(typeof(GameTypes)).Cast<GameTypes>();
            vm.GameList = from action in actionTypes
                             select new SelectListItem
                             {
                                 Text = action.ToString(),
                                 Value = action.ToString()
                             };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewHotlistItem(HotlistItem hotlistItem)
        {
            if (ModelState.IsValid)
            {
                hotlistItem.dateCreated = DateTime.Now;
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

        [Authorize(Roles = "Admin, Moderator")]
        public ActionResult EditHotlistItem(int id3)
        {
            return View(repository.GetHotlistItem(id3));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Moderator")]
        public ActionResult EditHotlistItem(HotlistItem hotlistItem)
        {
            repository.EditItem(hotlistItem);

            return RedirectToAction("Index", "Home", "Home");
        }
    }
}
