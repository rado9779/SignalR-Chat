using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Messages = new HashSet<Message>();
        }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
