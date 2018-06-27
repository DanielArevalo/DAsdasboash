using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Milton.Models;

namespace Milton.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult RecoverPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            System.Web.HttpContext.Current.Session["Session"] = false;
            ViewBag.LoginError = false;
            if (!ModelState.IsValid)
                return View(model);

            if (GetValidUser(model.Email, model.Password))
            {
                System.Web.HttpContext.Current.Session["Session"] = true;
                return RedirectToLocal(returnUrl);
            }

            ViewBag.LoginError = true;
            return View(model);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            return RedirectToAction("index", "Home");
        }

        private bool GetValidUser(string username, string password)
        {
            switch (username)
            {
                case "ricardo.ariza@bophelp.com":
                    return password.Equals("Bop123*");
                case "fabiola.franco@bophelp.com":
                    return password.Equals("Bop123*");
                case "sary.assef@bophelp.com":
                    return password.Equals("Bop123*");
                case "salvador.dacunha@bophelp.com":
                    return password.Equals("Bop123*");
                case "miller.ruiz@thomsongl.com":
                    return password.Equals("mRuizThomson123*");
                default:
                    return false;
            }
        }
    }
}