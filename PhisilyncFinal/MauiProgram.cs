using CommunityToolkit.Maui;
using System.Runtime;
using Microcharts.Maui;
using Microsoft.Extensions.Logging;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Views;
using SkiaSharp.Views.Maui.Controls.Hosting;
using PhisilyncFinal.Services.LennyAI.Interfaces;
using PhisilyncFinal.Services.LennyAI;
using PhisilyncFinal.LennyConfiguration;

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

            builder.RegisterServices()
                .RegisterViewModels()
                .RegisterViews();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }

        //Registering Pages
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<IPageService, TeamStatsVM>();
            mauiAppBuilder.Services.AddTransient<IAiAssistant, LennyAiAssistant>();
            mauiAppBuilder.Services.AddTransient<ISettings,AiSettings>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<LennyAiAnswerPage>();
            mauiAppBuilder.Services.AddSingleton<LennyAiQuestionPage>();
            mauiAppBuilder.Services.AddTransient<TellUsPage>();
            mauiAppBuilder.Services.AddTransient<SignUpPageAC>();
            mauiAppBuilder.Services.AddTransient<SignUpPageCoach>();
            mauiAppBuilder.Services.AddTransient<SignUpPageSP>();
            mauiAppBuilder.Services.AddTransient<AthleteDash>();
            mauiAppBuilder.Services.AddTransient<CoachDashboard>();
            mauiAppBuilder.Services.AddTransient<ServiceProviderDashboard>();
            mauiAppBuilder.Services.AddTransient<Payment>();
            mauiAppBuilder.Services.AddTransient<LogInPage>();
            mauiAppBuilder.Services.AddTransient<ProfileDetails>();
            mauiAppBuilder.Services.AddTransient<EditProfile>();
            mauiAppBuilder.Services.AddTransient<FAQs>();
            mauiAppBuilder.Services.AddTransient<InjuryLibraryPage>();
            mauiAppBuilder.Services.AddTransient<LynoTherapyPage>();
            mauiAppBuilder.Services.AddTransient<MassageTherapyPage>();
            mauiAppBuilder.Services.AddTransient<PrivacyPolicy>();
            mauiAppBuilder.Services.AddTransient<Settings>();
            mauiAppBuilder.Services.AddTransient<StretchesAndExercisePage>();
            mauiAppBuilder.Services.AddTransient<TACPage>();
            mauiAppBuilder.Services.AddTransient<TapingPage>();
            mauiAppBuilder.Services.AddTransient<TeamStatsPopUp>();
            mauiAppBuilder.Services.AddTransient<TreatmentPage>();
            //mauiAppBuilder.Services.AddTransient<LennyAiAnswerPage>();
            //mauiAppBuilder.Services.AddTransient<LennyAiQuestionPage>();
            mauiAppBuilder.Services.AddTransient<InjuryDetailsPage>();
            mauiAppBuilder.Services.AddTransient<GlossaryViewPage>();
            mauiAppBuilder.Services.AddTransient<GlossaryDetailsPage>();


            return mauiAppBuilder;
        }



            //Registering ViewModels
            public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
            {
            mauiAppBuilder.Services.AddSingleton<SignUpACVM>();
            mauiAppBuilder.Services.AddSingleton<SignUpCoachVM>();
            mauiAppBuilder.Services.AddSingleton<SignUpSPVM>();
            mauiAppBuilder.Services.AddSingleton<AthleteDashVM>();
                mauiAppBuilder.Services.AddSingleton<CoachDashVM>();
                mauiAppBuilder.Services.AddSingleton<SPDashVM>();
                mauiAppBuilder.Services.AddSingleton<ProfileDetailsVM>();
                mauiAppBuilder.Services.AddSingleton<EditProfileVM>();
                mauiAppBuilder.Services.AddSingleton<InjuryLibraryViewModel>();
                mauiAppBuilder.Services.AddSingleton<TeamStatsVM>();
                mauiAppBuilder.Services.AddSingleton<GlossaryViewModel>();
            mauiAppBuilder.Services.AddSingleton<LennyAnswerPageVM>();
            mauiAppBuilder.Services.AddSingleton<LennyQuestionPageVM>();

           

            return mauiAppBuilder;
            }  
    }
}
