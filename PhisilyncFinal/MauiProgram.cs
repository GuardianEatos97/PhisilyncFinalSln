using CommunityToolkit.Maui;
using Microcharts.Maui;
using Microsoft.Extensions.Logging;
using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Views;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace PhisilyncFinal
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMicrocharts()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<TellUsPage>();

            builder.Services.AddSingleton<TellUsPageVM>();

            builder.Services.AddTransient<SignUpPageAC>();

            builder.Services.AddSingleton<SUPageACVM>();


            return builder.Build();
        }
    }
}
