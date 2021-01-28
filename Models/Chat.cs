using System.Collections.Generic;

namespace SignalRChat.Models
{
    public class Chat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }

        public ICollection<Message> Messages { get; set; }

        public ChatType Type { get; set; }
    }
}
