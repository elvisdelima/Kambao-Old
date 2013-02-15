using Kambao.Data.Configuration;
using Kambao.Core;
using Kambao.Data;
using NHibernate.Context;
using Restfulie.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kambao.Controllers
{
    [ActAsRestfulie]
    public class FaixasController : CrudController<Faixa>
    {
        public FaixasController()
        {

        }

        public FaixasController(CrudData<Faixa> data)
            : base(data)
        {
        }
    }

        /*
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
         */
    
}
