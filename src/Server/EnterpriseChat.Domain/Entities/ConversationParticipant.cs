using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseChat.Domain.Entities
{
    public class ConversationParticipant : BaseEntity
    {

        public long UserId { get; set; }

        public DateTime JoinedAt { get; set; }

        public DateTime? LeftAt { get; set; }

        public virtual Conversation Conversation { get; set; }

        public virtual User User { get; set; }
    }
}
