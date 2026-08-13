using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseChat.Application.Features.Messages.Commands.SendMessage
{
    public sealed record SendMessageCommand(
        long SenderId,
        long ConversationId,
        string Content
    ) : IRequest<long>;
}
