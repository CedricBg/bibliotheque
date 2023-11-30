using bibliotheque.Data.DataAccess;
using bibliotheque.View;
using bibliotheque.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

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

            builder.Services.AddDbContext<BibliothequeContext>(options =>
            {
                options.UseSqlite("Data Source=.\\Data\\bibliotheque",
                o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
             });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
