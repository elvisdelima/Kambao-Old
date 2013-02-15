using Kambao.Data.Configuration;
using Kambao.Core;
using Kambao.Data;
using NHibernate.Context;
using NHibernate.Criterion;
using NHibernate.Transform;
using Restfulie.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kambao.Controllers
{

    [ActAsRestfulie]
    public class TarefasController : CrudController<Tarefa>
    {
        public TarefasController()
        {

        }

        public TarefasController(CrudData<Tarefa> data)
            : base(data)
        {
        }
    }



    /*
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
            
            session.Save(tarefa);

            return RedirectToAction("Index");
        }
    }   */
}
