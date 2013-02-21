using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kambao.Controllers;
using Kambao.Data;
using Kambao.Core;

namespace Kambao.Hubs
{
    public class QuadroHub : Hub
    {
        public void moveCard(int idTarefa, int idFaixa) {
            CrudData<Tarefa> TarefasData = new CrudData<Tarefa>();
            Tarefa tarefa = TarefasData.Get(idTarefa);

            CrudData<Faixa> FaixasData = new CrudData<Faixa>();
            Faixa faixa = FaixasData.Get(idFaixa);
            
            Clients.All.alterarFaixaDoCartao(tarefa, faixa);        
        }
    }    
}