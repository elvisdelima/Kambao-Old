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
            var fluentNh = new AutoMapper();
            var factory = fluentNh.GetSessionFactory();
            var session = factory.OpenSession();

            CurrentSessionContext.Bind(session);

            var tarefas = session.CreateCriteria<Tarefa>()
                //.Add(Restrictions.Eq("Nome", "Ojuara"))
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
            var fluentNh = new AutoMapper();
            var factory = fluentNh.GetSessionFactory();
            var session = factory.OpenSession();

            CurrentSessionContext.Bind(session);

            session.Save(tarefa);

            return RedirectToAction("Index");
        }
    }   
}
