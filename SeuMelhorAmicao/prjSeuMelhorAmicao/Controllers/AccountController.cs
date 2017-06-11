using prjSeuMelhorAmicao.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace prjSeuMelhorAmicao.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Login(Usuario model)
        {
            if (ModelState.IsValid)
            {


                FormsAuthentication.SetAuthCookie(model.Email, false);
                return RedirectToAction("Index", "Ong");
            }
            else
            {
                ModelState.AddModelError("", "Login ou/ Senha inválidos");
                return View(model);
            }
        }

        public ActionResult Registrar()
        {
            return View(new Ong());
        }

        [HttpPost]
        public ActionResult Registrar(Ong model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            return View();
        }
    }
}