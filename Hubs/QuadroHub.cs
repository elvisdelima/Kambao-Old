using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Hubs
{
    public class QuadroHub : Hub
    {
        public void MoveCard(string idTarefa, string idFaixa) 
        {
            Clients.All.alterarFaixaDoCartao(idTarefa, idFaixa);        
        }
    }    
}