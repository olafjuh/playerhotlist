using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace playerhotlist.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        DbRepository repository = new DbRepository();

        //[Authorize(Roles = "user")]
        public ActionResult Index(string sortOrder)
        {
            switch(sortOrder)
            {
                case "game":
                    return View(repository.GetAllItems().OrderBy(c => c.game));
                case "name":
                    return View(repository.GetAllItems().OrderBy(c => c.playerName));
                case "b3Id":
                    return View(repository.GetAllItems().OrderBy(c => c.b3ID));
                case "ts3Id":
                    return View(repository.GetAllItems().OrderBy(c => c.teamspeakID));
                case "status":
                    return View(repository.GetAllItems().OrderBy(c => c.status));
                case "date":
                    return View(repository.GetAllItems().OrderByDescending(c => c.dateCreated));
                default:
                    return View(repository.GetAllItems().OrderByDescending(c => c.dateCreated));
            }
            
        }
        //[Authorize(Roles = "admin")]
        public ActionResult Arma(string sortOrder)
        {
            switch (sortOrder)
            {
                case "game":
                    return View(repository.GetAllItems(1).OrderBy(c => c.game));
                case "name":
                    return View(repository.GetAllItems(1).OrderBy(c => c.playerName));
                case "b3Id":
                    return View(repository.GetAllItems(1).OrderBy(c => c.b3ID));
                case "ts3Id":
                    return View(repository.GetAllItems(1).OrderBy(c => c.teamspeakID));
                case "status":
                    return View(repository.GetAllItems(1).OrderBy(c => c.status));
                case "date":
                    return View(repository.GetAllItems(1).OrderByDescending(c => c.dateCreated));
                default:
                    return View(repository.GetAllItems(1).OrderBy(c => c.game));
            }
        }

        public ActionResult Aircav(string sortOrder)
        {
            switch (sortOrder)
            {
                case "game":
                    return View(repository.GetAllItems(2).OrderBy(c => c.game));
                case "name":
                    return View(repository.GetAllItems(2).OrderBy(c => c.playerName));
                case "b3Id":
                    return View(repository.GetAllItems(2).OrderBy(c => c.b3ID));
                case "ts3Id":
                    return View(repository.GetAllItems(2).OrderBy(c => c.teamspeakID));
                case "status":
                    return View(repository.GetAllItems(2).OrderBy(c => c.status));
                case "date":
                    return View(repository.GetAllItems(2).OrderByDescending(c => c.dateCreated));
                default:
                    return View(repository.GetAllItems(2).OrderBy(c => c.game));
            }
        }

        public ActionResult Counter(string sortOrder)
        {
            switch (sortOrder)
            {
                case "game":
                    return View(repository.GetAllItems(3).OrderBy(c => c.game));
                case "name":
                    return View(repository.GetAllItems(3).OrderBy(c => c.playerName));
                case "b3Id":
                    return View(repository.GetAllItems(3).OrderBy(c => c.b3ID));
                case "ts3Id":
                    return View(repository.GetAllItems(3).OrderBy(c => c.teamspeakID));
                case "status":
                    return View(repository.GetAllItems(3).OrderBy(c => c.status));
                case "date":
                    return View(repository.GetAllItems(3).OrderByDescending(c => c.dateCreated));
                default:
                    return View(repository.GetAllItems(3).OrderBy(c => c.game));
            }
        }

        public ActionResult Squad(string sortOrder)
        {
            switch (sortOrder)
            {
                case "game":
                    return View(repository.GetAllItems(4).OrderBy(c => c.game));
                case "name":
                    return View(repository.GetAllItems(4).OrderBy(c => c.playerName));
                case "b3Id":
                    return View(repository.GetAllItems(4).OrderBy(c => c.b3ID));
                case "ts3Id":
                    return View(repository.GetAllItems(4).OrderBy(c => c.teamspeakID));
                case "status":
                    return View(repository.GetAllItems(4).OrderBy(c => c.status));
                case "date":
                    return View(repository.GetAllItems(4).OrderByDescending(c => c.dateCreated));
                default:
                    return View(repository.GetAllItems(4).OrderBy(c => c.game));
            }
        }

        //public ActionResult ActiveList(int i)
        //{
        //    return View(repository.GetAllItems(i));
        //}
        
        public ActionResult NewHotlistItem()
        {
            return View();
        }
    }
}
