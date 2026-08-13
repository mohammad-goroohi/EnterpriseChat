using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseChat.Domain.Entities
{
    public class Conversation
    {
        public long Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<ConversationParticipant> Participants { get; set; }

        public Conversation()
        {
            Messages = new HashSet<Message>();
            Participants = new HashSet<ConversationParticipant>();
        }
    }
}
