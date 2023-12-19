using Microsoft.AspNetCore.SignalR;

namespace SignalRWebpages.Hubs
{
    public class ChatHub :Hub
    {
        public async Task SendMessage(String user, String message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }
    }
}
