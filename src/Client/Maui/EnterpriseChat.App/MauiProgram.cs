using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;

namespace EnterpriseChat.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton(service =>
            {
                return new HubConnectionBuilder()
                 .WithUrl("http://localhost:53353/ChatHub")
                 .Build();
            });

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
