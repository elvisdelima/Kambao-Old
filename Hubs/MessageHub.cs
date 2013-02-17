using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Hubs
{
    public class MessageHub : Hub
    {
        public void SendMessage(string message) 
        {
            Clients.All.writeMessage(message);
        }
    }
}