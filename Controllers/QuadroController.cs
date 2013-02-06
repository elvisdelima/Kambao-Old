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
            var session = SessionProvider.CurrentSession;

            var tarefas = session.CreateCriteria<Tarefa>()
                .List<Tarefa>();

            return View(tarefas);
        }

    }
}
