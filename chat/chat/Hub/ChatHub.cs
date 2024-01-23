﻿using Microsoft.AspNetCore.SignalR;
namespace chat.Hub
{
    public class ChatHub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
