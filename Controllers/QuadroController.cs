using Kambao.Data.Configuration;
using Kambao.Core;
using NHibernate.Context;
using Restfulie.Server.Results;
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

            var faixas = session.CreateCriteria<Faixa>()
               .List<Faixa>() as List<Faixa>;
            var tarefas = session.CreateCriteria<Tarefa>()
                .List<Tarefa>() as List<Tarefa>;
           
            Quadro quadro = new Quadro();
            quadro.faixas = faixas;            
            quadro.tarefas = tarefas;
            
            return View(quadro);
        }

    }
}
