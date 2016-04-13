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
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account model)
        {
            if (ModelState.IsValid)
            {
                Account account = repository.GetAccount(model.name, model.password);
                if (account != null)
                {
                    //niet persistent (false) werkt alleen in firefox, chrome bewaard deze wel.
                    FormsAuthentication.SetAuthCookie(account.name, false);

                    //remember complete account
                    

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


    }
}
