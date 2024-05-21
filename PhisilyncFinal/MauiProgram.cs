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

            //Registering Pages
            builder.Services.AddTransient<TellUsPage>();
            builder.Services.AddTransient<SignUpPageAC>();
            builder.Services.AddTransient<SignUpPageCoach>();
            builder.Services.AddTransient<SignUpPageSP>();
            builder.Services.AddTransient<AthleteDash>();
            builder.Services.AddTransient<CoachDashboard>();
            builder.Services.AddTransient<ServiceProviderDashboard>();
            builder.Services.AddTransient<Payment>();
            builder.Services.AddTransient<LogInPage>();
            builder.Services.AddTransient<ProfileDetails>();
            builder.Services.AddTransient<EditProfile>();
            builder.Services.AddTransient<FAQs>();
            builder.Services.AddTransient<InjuryPage>();
            builder.Services.AddTransient<LynoTherapyPage>();
            builder.Services.AddTransient<MassageTherapyPage>();
            builder.Services.AddTransient<PrivacyPolicy>();
            builder.Services.AddTransient<Settings>();
            builder.Services.AddTransient<StretchesAndExercisePage>();
            builder.Services.AddTransient<TACPage>();
            builder.Services.AddTransient<TapingPage>();
            builder.Services.AddTransient<TeamStatsPopUp>();
            builder.Services.AddTransient<TreatmentPage>();



            //Registering ViewModels 
            builder.Services.AddSingleton<AthleteDashVM>();
            builder.Services.AddSingleton<CoachDashVM>();
            builder.Services.AddSingleton<SPDashVM>();
            builder.Services.AddSingleton<ProfileDetailsVM>();
            builder.Services.AddSingleton<EditProfileVM>();
            builder.Services.AddSingleton<InjuryViewModel>();
            builder.Services.AddSingleton<LynoTherapyPageVM>();
            builder.Services.AddSingleton<MassageTherapyVM>();
            builder.Services.AddSingleton<StretchesandExercisesVM>();
            builder.Services.AddSingleton<TapingPageVM>();
            builder.Services.AddSingleton<TeamStatsVM>();
            builder.Services.AddSingleton<TreatmentPageVM>();
            




            return builder.Build();
        }
    }
}
