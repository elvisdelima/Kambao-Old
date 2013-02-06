using Kambao.Configuration;
using Kambao.Models;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kambao.Controllers
{
    public class FaixasController : Controller
    {
        public ActionResult Index()
        {
            var session = SessionProvider.CurrentSession;
            var faixas = session.CreateCriteria<Faixa>()
                .List<Faixa>();
         
            return View(faixas);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Faixa faixa)
        {
            var session = SessionProvider.CurrentSession;
            session.Save(faixa);

            return RedirectToAction("Index");
        }
    }
}
