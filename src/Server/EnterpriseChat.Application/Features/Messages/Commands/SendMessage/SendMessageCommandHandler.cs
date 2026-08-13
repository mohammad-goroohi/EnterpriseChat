using Chat.Application.Common.Interfaces;
using EnterpriseChat.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseChat.Application.Features.Messages.Commands.SendMessage
{
    public sealed class SendMessageCommandHandler
        : IRequestHandler<SendMessageCommand, long>
    {
        private readonly IApplicationDbContext _context;
        public SendMessageCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<long> Handle(
            SendMessageCommand request,
            CancellationToken cancellationToken)
        {
            // بررسی وجود Conversation
            var conversationExists = await _context.Conversations
                .AnyAsync(
                    x => x.Id == request.ConversationId,
                    cancellationToken);

            if (!conversationExists)
                throw new InvalidOperationException(
                    "Conversation does not exist.");

            // بررسی اینکه کاربر عضو Conversation است
            var participantExists = await _context.ConversationParticipants
                .AnyAsync(
                    x =>
                        x.Id == request.ConversationId &&
                        x.UserId == request.SenderId,
                    cancellationToken);

            if (!participantExists)
                throw new InvalidOperationException(
                    "User is not a participant of this conversation.");

            var message = new Message
            {
                SenderId = request.SenderId,
                ConversationId = request.ConversationId,
                Content = request.Content,
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false
            };

            _context.Messages.Add(message);

            await _context.SaveChangesAsync(cancellationToken);

            return message.Id;
        }
    }
}
