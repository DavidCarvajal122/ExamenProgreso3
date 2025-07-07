using Microsoft.Extensions.Logging;
using ExamenProgreso3.ViewModels;
using ExamenProgreso3.Services;

namespace ExamenProgreso3
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<DatabaseService>();
            builder.Services.AddSingleton<LogService>();

            builder.Services.AddTransient<ListaBDViewModel>();
            builder.Services.AddTransient<LogsViewModel>();

            return builder.Build();
        }
    }
}
