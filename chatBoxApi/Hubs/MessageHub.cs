using chatBoxApi.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatBoxApi.Hubs
{
  public class MessageHub: Hub
  {
    public async Task chatMessage(MessagesModel message)
    {
      await Clients.All.SendAsync("MessageRecieved", message);
    }
  }
}
