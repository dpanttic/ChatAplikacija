<<<<<<< HEAD
﻿using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(ProjekatChatAplikacijaSignalRChat.Startup))]

namespace ProjekatChatAplikacijaSignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
=======
﻿using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(ProjekatChatAplikacijaSignalRChat.Startup))]

namespace ProjekatChatAplikacijaSignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
>>>>>>> faf3af7d553bbbc30d622d46884f0fa16f7dfd6e
