using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Server
{
    public class MessageHub: Hub
    {
        public async Task SendMessage(string userName, string message)
        {
            await Clients.All.SendAsync("xyz", userName, message);
        }
    }
}