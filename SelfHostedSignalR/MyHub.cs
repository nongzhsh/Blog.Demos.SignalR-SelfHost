﻿using Microsoft.AspNet.SignalR;

namespace SelfHostedSignalR
{
    public class MyHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }
    }
}