using prjSeuMelhorAmicao.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjSeuMelhorAmicao.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult Index(string pesquisa)
        {
            return View(new List<Animal>());
        }

        public ActionResult Create()
        {
            return View(new Animal());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Animal model)
        {
            return View(new Animal());
        }
    }
}