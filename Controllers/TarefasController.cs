using Kambao.Configuration;
using Kambao.Models;
using NHibernate.Context;
using NHibernate.Criterion;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kambao.Controllers
{
    public class TarefasController : Controller
    {        
        public ActionResult Index()
        {
            var session = SessionProvider.CurrentSession;

            var tarefas = session.CreateCriteria<Tarefa>()
                .List<Tarefa>();
            
            return View(tarefas);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tarefa tarefa)
        {
            var session = SessionProvider.CurrentSession;

            tarefa.faixa = new Faixa();
            tarefa.faixa.Id = 1;
            //tarefa.faixa.Id = 1;

            session.Save(tarefa);

            return RedirectToAction("Index");
        }
    }   
}
