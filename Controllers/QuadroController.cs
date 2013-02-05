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
    public class QuadroController : Controller
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

    }
}
