using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Views;

namespace PhisilyncFinal
{
    
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes() 
        {
            Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));
            Routing.RegisterRoute("CoachDash", typeof(CoachDashboard));
            Routing.RegisterRoute("EditProfile", typeof(EditProfile));
            Routing.RegisterRoute("FAQs", typeof(FAQs));
            Routing.RegisterRoute("InjuryDetailsPage", typeof(InjuryDetailsPage));
            Routing.RegisterRoute("Library", typeof(InjuryLibraryPage));
            Routing.RegisterRoute("LogInPage", typeof(LogInPage));
            Routing.RegisterRoute("LynoPage", typeof(LynoTherapyPage));
            Routing.RegisterRoute("MassagePage", typeof(MassageTherapyPage));
            Routing.RegisterRoute("Payment", typeof(Payment));
            Routing.RegisterRoute("PrivacyPolicy", typeof(PrivacyPolicy));
            Routing.RegisterRoute("ProfileDetails", typeof(ProfileDetails));
            Routing.RegisterRoute("ROMPage", typeof(RangeOfMovementPage));
            Routing.RegisterRoute("SPDash", typeof(ServiceProviderDashboard));
            Routing.RegisterRoute("Settings", typeof(Settings));
            Routing.RegisterRoute("SUAthlete", typeof(SignUpPageAC));
            Routing.RegisterRoute("SUCoach", typeof(SignUpPageCoach));
            Routing.RegisterRoute("SUSP", typeof(SignUpPageSP));
            Routing.RegisterRoute("Stretch", typeof(StretchesAndExercisePage));
            Routing.RegisterRoute("TACPage", typeof(TACPage));
            Routing.RegisterRoute("Taping", typeof(TapingPage));
            Routing.RegisterRoute("TeamStats", typeof(TeamStatsPopUp));
            Routing.RegisterRoute("TellUs", typeof(TellUsPage));
            Routing.RegisterRoute("TestPage", typeof(TestPage));
            Routing.RegisterRoute("Treatment", typeof(TreatmentPage));

        }
    }
}
