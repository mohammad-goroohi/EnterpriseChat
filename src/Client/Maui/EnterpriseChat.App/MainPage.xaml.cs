using Microsoft.AspNetCore.SignalR.Client;

namespace EnterpriseChat.App
{
    public partial class MainPage : ContentPage
    {
        public HubConnection _hubConnection { get; set; }

        public MainPage(HubConnection hubConnection)
        {
            _hubConnection = hubConnection;
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await InitializeHubConnectionAsync();
        }
        public async Task InitializeHubConnectionAsync()
        {
            _hubConnection.Closed += HubConnection_Closed;
            _hubConnection.On<string>("ReciveMessage", mess =>
            {

            });
            await _hubConnection.StartAsync();
        }

        private async Task HubConnection_Closed(Exception? arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await _hubConnection.StartAsync();
        }
    }
}
