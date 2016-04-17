using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using playerhotlist.Models;

namespace playerhotlist.Controllers
{
    public class AccountController : Controller
    {
        private DbRepository repository = new DbRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account model)
        {
            if (ModelState.IsValid && repository.IsValidatedUser(model.name, model.password))
            {
                Account account = repository.GetAccount(model.name, model.password);
                if (account != null)
                {
                    //niet persistent (false) werkt alleen in firefox, chrome bewaard deze wel.
                    FormsAuthentication.SetAuthCookie(account.name, false);

                    //redirect to default entry of Contact Controller
                    return RedirectToAction("Index", "Home");
                    //return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("login-error", "The user name or password provided is/are incorrect.");
                    return View(model);
                }
            }
            //error --> go back to login page
            return View(model);
        }

        public ActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            //session = 0;
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                repository.RegisterAccount(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AdminPage(string sortOrder)
        {
            switch (sortOrder)
            {
                case "name":
                    return View(repository.GetAllAccounts().OrderBy(c => c.name).ToList());
                case "roleId":
                    return View(repository.GetAllAccounts().OrderBy(c => c.roleID).ToList());                
                default:
                    return View(repository.GetAllAccounts().OrderBy(c => c.name).ToList());
            }
        }

        public ActionResult EditAccount(int id)
        {
            return View(repository.GetAccount(id));
        }

        [HttpPost]
        public ActionResult EditAccount(Account account)
        {
            repository.UpdateAccount(account);
            return View(repository.GetAccount(account.Id));
        }

        public ActionResult Manage()
        {
            return View();
        }
    }
}
