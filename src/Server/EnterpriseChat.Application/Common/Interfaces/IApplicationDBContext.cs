using EnterpriseChat.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace Chat.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }

        DbSet<Message> Messages { get; }

        DbSet<Conversation> Conversations { get; }

        DbSet<ConversationParticipant> ConversationParticipants { get; }

        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken);
    }
}
