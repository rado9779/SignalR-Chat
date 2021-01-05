using System;

namespace SignalRChat.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
