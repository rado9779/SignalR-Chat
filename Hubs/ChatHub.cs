using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Models;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ChatHub(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task SendMessage(string inputMessage)
        {
            var username = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            await Clients.All.SendAsync("ReceiveMessage", username, inputMessage);
        }
    }
}
