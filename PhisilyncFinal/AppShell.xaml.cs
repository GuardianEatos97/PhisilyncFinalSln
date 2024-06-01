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
            Routing.RegisterRoute("athleteDash", typeof(AthleteDash));
            Routing.RegisterRoute("coachDash", typeof(CoachDashboard));
            Routing.RegisterRoute("EditProfile", typeof(EditProfile));
            Routing.RegisterRoute("FAQs", typeof(FAQs));
            Routing.RegisterRoute("InjuryDetailsPage", typeof(InjuryDetailsPage));
            Routing.RegisterRoute("Library", typeof(InjuryLibraryPage));
            Routing.RegisterRoute("LogInPage", typeof(LogInPage));
            Routing.RegisterRoute("LynoPage", typeof(LynoTherapyPage));
            Routing.RegisterRoute("MassagePage", typeof(MassageTherapyPage));
            Routing.RegisterRoute("Payment", typeof(PaymentPage));
            Routing.RegisterRoute("PrivacyPolicy", typeof(PrivacyPolicy));
            Routing.RegisterRoute("ProfileDetails", typeof(ProfileDetails));
            Routing.RegisterRoute("ROMPage", typeof(RangeOfMovementPage));
            Routing.RegisterRoute("sPDash", typeof(ServiceProviderDashboard));
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
            Routing.RegisterRoute("GlossaryView", typeof(GlossaryViewPage));
            Routing.RegisterRoute("GlossaryDetails", typeof(GlossaryDetailsPage));
            Routing.RegisterRoute("AnswerPage", typeof(LennyAiAnswerPage));
            Routing.RegisterRoute("QuestionPage", typeof(LennyAiQuestionPage));
            Routing.RegisterRoute("TestAndReleasePage", typeof(TestAndReleasePage));
            Routing.RegisterRoute("SelectedInjuryDetails", typeof(SelectedInjuryDetailsPage));
            Routing.RegisterRoute("SelectInjury", typeof(SelectInjuryPage));

        }
    }
}
