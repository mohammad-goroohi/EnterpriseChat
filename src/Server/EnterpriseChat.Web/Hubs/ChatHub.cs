using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{

    public async Task SendMessage(
        int conversationId,
        string message)
    {

    }

    public async Task JoinConversation(int conversationId)
    {

    }

    public async Task LeaveConversation(int conversationId)
    {

    }

    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await base.OnDisconnectedAsync(exception);
    }
}