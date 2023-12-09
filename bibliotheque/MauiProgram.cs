
using bibliotheque.DataAccess.Services;
using bibliotheque.View;
using bibliotheque.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;


namespace bibliotheque
{
    public static class MauiProgram
    {

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                });

            builder.Services.AddSingleton<IndexPage>();
            builder.Services.AddSingleton<AddBookPage>();

            builder.Services.AddSingleton<IndexPageviewModel>();
            builder.Services.AddSingleton<AddBookPageViewModel>();

            builder.Services.AddSingleton<BookService>();
            builder.Services.AddSingleton<OwnerService>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
