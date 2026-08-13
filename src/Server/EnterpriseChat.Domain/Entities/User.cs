using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseChat.Domain.Entities
{
    public class User: BaseEntity
    {

        public string UserName { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<ConversationParticipant> ConversationParticipants { get; set; }

        public User()
        {
            Messages = new HashSet<Message>();
            ConversationParticipants = new HashSet<ConversationParticipant>();
        }
    }
}
