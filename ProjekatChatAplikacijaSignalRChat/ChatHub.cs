<<<<<<< HEAD
﻿using Microsoft.AspNet.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjekatChatAplikacijaSignalRChat
{
    public class ChatHub : Hub
    {
        private static List<string> activeUsers = new List<string>();

        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

        public void Connect(string userName)
        {
            activeUsers.Add(userName);
            Clients.All.updateActiveUsersCount(activeUsers.Count, activeUsers);
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            string userName = Context.QueryString["userName"];
            activeUsers.Remove(userName);
            Clients.All.updateActiveUsersCount(activeUsers.Count, activeUsers);
            return base.OnDisconnected(stopCalled);
        }
    }
}
=======
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjekatChatAplikacijaSignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}
>>>>>>> faf3af7d553bbbc30d622d46884f0fa16f7dfd6e
