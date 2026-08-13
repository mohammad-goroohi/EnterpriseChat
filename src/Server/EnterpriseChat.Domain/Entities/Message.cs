using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseChat.Domain.Entities
{
    public class Message : BaseEntity
    {

        public long SenderId { get; set; }

        public long ConversationId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? EditedAt { get; set; }

        public bool IsDeleted { get; set; }

        public virtual User Sender { get; set; }

        public virtual Conversation Conversation { get; set; }
    }
}
